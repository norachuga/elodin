using System;

namespace Elodin.Core
{
    public class PaintColor
    {
        public string Name { get; set; }

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public decimal Hue { get; set; }
        public decimal Saturation { get; set; }
        public decimal Value { get; set; }

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
            double r = Red / 255d;
            double g = Green / 255d;
            double b = Blue / 255d;

            var max = Math.Max(r, Math.Max(g, b));
            var min = Math.Min(r, Math.Min(g, b));

            double h = max;
            double s = max;
            double v = max;


            var d = max - min;
            s = (max == 0) ? 0 : (d / max);

            if (max == min)
            {
                h = 0; // achromatic
            }
            else
            {
                if (max == r)
                {
                    h = (g - b) / d + (g < b ? 6 : 0);
                }
                else
                {
                    if (max == g)
                    {
                        h = (b - r) / d + 2;
                    }
                    else
                    {
                        if (max == b)
                        {
                            h = (r - g) / d + 4;
                        }
                        else
                        {
                            h /= 6;
                        }
                    }
                }
            }

            Hue = (decimal)Math.Round(h, 4);
            Saturation = (decimal)Math.Round(s, 4);
            Value = (decimal)Math.Round(v, 4);
        }
    }
}
