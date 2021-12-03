using System;
using System.Collections.Generic;
using System.Linq;

namespace Elodin.Core
{
    public class ColorNamer
    {
        // the sweet spot
        private const double HueRange = 10d;
        private const double SaturationRange = 0.3d;
        private const double ValueRange = 0.6d;

        /// <summary>
        /// The source color data. 
        /// </summary>
        public List<PaintColor> Catalog { get; set; }

        public ColorNamer()
        {
            Catalog = new List<PaintColor>();
        }

        public ColorNamer(IEnumerable<PaintColor> paintNames)
        {
            Catalog = paintNames.ToList();
        }

        /// <summary>
        /// Finds similar colors within the defined HSV range and returns the names of all those colors.
        /// </summary>
        public List<string> GetAdjacentColorNames(int r, int g, int b)
        {
            var target = new PaintColor("", r, g, b);

            var colorsInRange = Catalog.Where(color =>
                color.Hue >= (target.Hue - HueRange) && color.Hue <= (target.Hue + HueRange)
                && color.Saturation >= (target.Saturation - SaturationRange) && color.Saturation <= (target.Saturation + SaturationRange)
                && color.Value >= (target.Value - ValueRange) && color.Value <= (target.Value + ValueRange)
            );

            var names = colorsInRange.Select(color => color.Name).ToList();

            if (!names.Any())
                throw new InsufficientSourceDataException("No matches in range found. You probably need more colors in the catalog.");

            return names;
        }

        /// <summary>
        /// Builds a markov chain from the names of similar colors and generates a potential name for the given color.
        /// </summary>
        public string GenerateColorName(int markovDepth, int r, int g, int b)
            => GenerateColorNames(1, markovDepth, r, g, b).First();

        /// <summary>
        /// Builds a markov chain from the names of similar colors and generates potential names for the given color.
        /// </summary>
        public List<string> GenerateColorNames(int count, int markovDepth, int r, int g, int b)
        {
            var sourceData = GetAdjacentColorNames(r, g, b);

            var generator = new NameGenerator(markovDepth, sourceData);

            return generator.GenerateUniqueNames(count).ToList();
        }

    }
}
