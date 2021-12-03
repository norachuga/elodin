using Elodin.Core;
using System;

namespace Elodin.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: the test data set is too small to reliably handle full random. (600 colors vs 100k+ colors in the real dataset)
            // You'll likely need to run this a few times until you get a color that works.
            // Here's a couple RGB values that will definitely work with the data set: (185,193,37), (177, 223, 99), (232,72,49)

            var rng = new Random();

            // generate a random color
            int red = rng.Next(256);
            int green = rng.Next(256);
            int blue = rng.Next(256);


            Console.WriteLine($"Random RGB color: {red}, {green}, {blue}\n");
            Console.WriteLine("since you can't effectively show color in the console, you can view this color here:");

            var link = $"https://www.thecolorapi.com/id?format=svg&named=false&hex={red.ToString("X")}{green.ToString("X")}{blue.ToString("X")}";

            Console.WriteLine(link);

            // load up a namer of names using the test data.
            var elodin = new ColorNamer(TestData.Colors);

            // generate some names!
            var names = elodin.GenerateColorNames(3, 3, red, green, blue);

            Console.WriteLine("\nGenerated these names for this color:\n");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
