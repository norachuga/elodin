using System.Collections.Generic;

namespace Elodin.Core
{
    public class NameGenerator
    {
        private readonly MarkovChain _chain;
        private readonly List<string> _sourceNames;

        // when working with small datasets, you may end up unable to generate new or unique names.
        // So a cap is needed to prevent infinite loops.
        private const int MaxAttempts = 25; 

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
            int attempts = 0;
            do
            {
                name = GenerateName();

                ThrowIfTooManyAttempts(attempts);

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
            
            var names = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string name;
                int attempts = 0;
                do
                {
                    name = GenerateNewName();

                    ThrowIfTooManyAttempts(attempts);

                } while (names.Contains(name));

                names.Add(name);
            }

            return names;
        }

        /// <summary>
        /// Increments attempt counter and throws if it exceeds the MaxAttempts const
        /// </summary>
        private void ThrowIfTooManyAttempts(int attempts)
        {
            attempts++; 

            if (attempts > MaxAttempts)
                throw new InsufficientSourceDataException("Exceeded max attempts to get a new or unique name. The desired count may be higher than the source data can produce.");
        }
    }
}