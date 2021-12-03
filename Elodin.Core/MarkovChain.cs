using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elodin.Core
{
    public class MarkovChain
    {
        private readonly int _stateDepth;

        private readonly Dictionary<string, Dictionary<char, int>> _history;
        private readonly Dictionary<string, int> _terminalStates;

        public MarkovChain(int stateDepth)
        {
            if (stateDepth < 0)
                throw new ArgumentOutOfRangeException(nameof(stateDepth), "Must be >= 1");

            _stateDepth = stateDepth;
            _history = new Dictionary<string, Dictionary<char,int>>();
            _terminalStates = new Dictionary<string, int>();
        }

        public void AddSourceName(string name)
        {
            string state = "";

            // we want to track states in accordance with the state depth, but for depths >1,
            // our states have to start off smaller. example: "example" -> "e","ex","exa"
            int startIndex = 0;
            int length = 0;

            foreach (char character in name)
            {
                AddStateAntecedent(state, character);

                // increase the length of our states until we reach the max,
                // and then just move the index forward so we keep pulling that same state depth
                if (length < _stateDepth)
                    length++;
                else
                    startIndex++;

                //substring the name to the current state depth
                state = name.Substring(startIndex, length);
            }

            AddTerminalState(state);
        }

        private void AddStateAntecedent(string state, char antecedent)
        {
            // determine if we already have a record for this state
            if (_history.ContainsKey(state))
            {
                // state exists already, so check if we already have a record for the antecedent
                if (_history[state].ContainsKey(antecedent))
                {
                    // existing antecedent - increase its weight
                    _history[state][antecedent]++;
                }
                else
                {
                    // new antecedent - add with a weight of 1
                    _history[state].Add(antecedent, 1);
                }
            }
            else
            {
                // add new state and its antecedent with a weight of 1
                _history.Add(state, new Dictionary<char, int> { { antecedent, 1 } });
            }
        }

        private void AddTerminalState(string state)
        {
            if (_terminalStates.ContainsKey(state))
                _terminalStates[state]++; //existing terminal state - increase its weight
            else
                _terminalStates.Add(state, 1); //new terminal state - add with weight of 1
        }

        public string RandomlyWalk()
            => RandomlyWalk(new Random());

        public string RandomlyWalk(int seed)
            => RandomlyWalk(new Random(seed));

        private string RandomlyWalk(Random rng)
        {
            var generatedName = new StringBuilder();

            //state always begins with an empty string. When loading names in, the first state is an empty string.
            //so this sets us up to begin at the beginnings, so to speak.
            var stateQueue = new Queue<char>("");

            while (true)
            {
                // once our state has reached the depth, dequeue each loop so the state stays at that depth
                if (stateQueue.Count > _stateDepth)
                    stateQueue.Dequeue();

                // turn that char collection into a string
                var currentState = new string(stateQueue.ToArray());

                // if we've achieved a state that we have no antecedents for,
                // then we are unable to generate any further.
                if (!_history.ContainsKey(currentState))
                {
                    return generatedName.ToString();
                }

                var antecedents = _history[currentState];
                int totalAntecedentWeight = antecedents.Sum(x => x.Value);

                // if we've achieved a terminal state, we're going to add its weight in to our dice roll.
                _terminalStates.TryGetValue(currentState, out int terminalWeight);

                // generate a number between 0 and the combined weights of the antecedents and the terminal state (inclusive).
                var diceRoll = rng.Next(totalAntecedentWeight + terminalWeight) + 1;

                // picture a pie chart with two colors. One color is the antecedent weight, the other is the terminal weight.
                // then we spin that pie chart like a wheel. if it lands on the terminal side of the chart, then the game ends.
                // (but if we didn't have a terminal state, then the terminal side is zero, and can't be lost yet.)
                // so the generation continues until either we reach an unprecedented state, or we hit a winning terminal state.

                if (diceRoll > totalAntecedentWeight)
                {
                    return generatedName.ToString();
                }

                // now that we've established the generation should continue, let's generate the next char.

                //randomly order the antecedents, so we aren't biased towards earlier sources.
                var antecedentsInRandomOrder = antecedents.OrderBy(x => rng.Next());

                var risingCheck = 0;
                foreach (var antecedent in antecedentsInRandomOrder)
                {
                    // loop over every possible antecedent, adding its weight to the check value.
                    risingCheck += antecedent.Value;

                    // if adding an antecedent's weight meets or exceeds the threshold defined by the dice roll
                    if (risingCheck >= diceRoll)
                    {
                        // then we call that a winning antecedent, and add it to the name.
                        generatedName.Append(antecedent.Key);

                        // and add it to the state
                        stateQueue.Enqueue(antecedent.Key);

                        break;
                    }
                }
            }
        }
    }
}
