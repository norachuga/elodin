using System;
using System.Collections.Generic;

namespace Elodin.Core
{
    public class NameGenerator
    {
        private readonly MarkovChain _chain;
        private readonly List<string> _sourceNames;

        public NameGenerator(int stateDepth, IEnumerable<string> names)
        {
            _chain = new MarkovChain(stateDepth);
            _sourceNames = new List<string>();

            foreach (var name in names)
            {
                _chain.AddSourceName(name);
                _sourceNames.Add(name);
            }
        }

        /// <summary>
        /// Generates a name
        /// </summary>
        public string GenerateName()
        {
            var name = _chain.RandomlyWalk();
            return name;
        }

        /// <summary>
        /// Generates a name, starting the walk from the given seed.
        /// (This method is mainly for comparing results when making tweaks to the MarkovChain code)
        /// </summary>
        public string GenerateName(int rngSeed)
        {
            var name = _chain.RandomlyWalk(rngSeed);
            return name;
        }

        /// <summary>
        /// Generates a name, making sure not to generate one that was in the source data.
        /// </summary>
        public string GenerateNewName()
        {
            string name;
            do
            {
                name = GenerateName();
            } while (_sourceNames.Contains(name));

            return name;
        }

        /// <summary>
        /// Generates a given number of names
        /// </summary>
        public IEnumerable<string> GenerateNames(int count)
        {
            var names = new List<string>();
            for (int i = 0; i < count; i++)
            {
                names.Add(GenerateName());
            }

            return names;
        }

        /// <summary>
        /// Generates a given number of names, making sure not to generate one that was in the source data.
        /// </summary>
        public IEnumerable<string> GenerateNewNames(int count)
        {
            var names = new List<string>();
            for (int i = 0; i < count; i++)
            {
                names.Add(GenerateNewName());
            }

            return names;
        }

        /// <summary>
        /// Generates a given number of names, making sure to not include any duplicates or anything from the source data.
        /// </summary>
        public IEnumerable<string> GenerateUniqueNames(int count)
        {
            const int maxAttempts = 25;
            var names = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string name;
                int attempts = 0;
                do
                {
                    name = GenerateNewName();
                    attempts++;

                    if (attempts > maxAttempts)
                        throw new Exception("Exceeded max attempts to get a unique name. The desired count may be higher than the source data can produce.");

                } while (names.Contains(name));

                names.Add(name);
            }

            return names;
        }
    }
}