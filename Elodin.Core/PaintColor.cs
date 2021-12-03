using System;

namespace Elodin.Core
{
    public class PaintColor
    {
        public string Name { get; set; }

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public double Hue { get; set; }
        public double Saturation { get; set; }
        public double Value { get; set; }

        public PaintColor() { }
        public PaintColor(string name, int r, int g, int b)
        {
            Name = name;
            Red = r;
            Green = g;
            Blue = b;

            CalculateHsv();
        }

        private void CalculateHsv()
        {
            double max = Math.Max(Red, Math.Max(Green, Blue));
            double min = Math.Min(Red, Math.Min(Green, Blue));

            // System.Drawing uses HSL, not HSV, but Hue is calculated the same way in both color models.
            Hue = System.Drawing.Color.FromArgb(Red, Green, Blue).GetHue();

            if (max == 0)
                Saturation = 0;
            else
                Saturation = ((max - min) / max);

            Value = (max / 255d);
        }
    }
}
