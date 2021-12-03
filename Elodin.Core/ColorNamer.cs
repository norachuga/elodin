using System;
using System.Collections.Generic;
using System.Linq;

namespace Elodin.Core
{
    public class ColorNamer
    {
        // the sweet spot
        private const decimal HueRange = 0.5m;
        private const decimal SaturationRange = 0.3m;
        private const decimal ValueRange = 0.6m;

        public List<PaintColor> Catalog { get; set; }

        public ColorNamer()
        {
            Catalog = new List<PaintColor>();
        }

        public ColorNamer(IEnumerable<PaintColor> paintNames)
        {
            Catalog = paintNames.ToList();
        }

        public List<string> GetAdjacentColorNames(int r, int g, int b)
        {
            var target = new PaintColor("", r, g, b);

            var colorsInRange = Catalog.Where(color =>
                color.Hue >= (target.Hue - HueRange) && color.Hue <= (target.Hue + HueRange)
                && color.Saturation >= (target.Saturation - SaturationRange) && color.Saturation <= (target.Saturation + SaturationRange)
                && color.Value >= (target.Value - ValueRange) && color.Hue <= (target.Value + ValueRange)
            );

            var names = colorsInRange.Select(color => color.Name).ToList();

            if (!names.Any())
                throw new Exception("No matches in range found. You probably need more colors in the catalog.");

            return names;
        }

        public string GenerateColorName(int markovDepth, int r, int g, int b)
            => GenerateColorNames(1, markovDepth, r, g, b).First();

        public List<string> GenerateColorNames(int count, int markovDepth, int r, int g, int b)
        {
            var sourceData = GetAdjacentColorNames(r, g, b);

            var generator = new NameGenerator(markovDepth, sourceData);

            return generator.GenerateUniqueNames(count).ToList();
        }

    }
}
