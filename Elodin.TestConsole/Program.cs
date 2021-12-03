using Elodin.Core;
using System;

namespace Elodin.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: the test data set is too small to reliably handle full random. (600 colors vs 100k+ colors in the real dataset)
            // It is likely the RNG will take a few tries to hit on a color we have enough data for.

            const int maxAttempts = 25;

            int attempts = 0;           
            while (attempts < maxAttempts)
            {
                try
                {
                    var rng = new Random();

                    // generate a random color
                    int red = rng.Next(256);
                    int green = rng.Next(256);
                    int blue = rng.Next(256);

                    Console.WriteLine($"Random RGB color: {red}, {green}, {blue}");

                    // load up a namer of names using the test data.
                    var elodin = new ColorNamer(TestData.Colors);

                    // generate some names!
                    var names = elodin.GenerateColorNames(3, 3, red, green, blue);

                    Console.WriteLine("\nsince you can't effectively show color in the console, you can view this color here:");
                    Console.WriteLine($"https://www.thecolorapi.com/id?format=svg&named=false&hex={red.ToString("X")}{green.ToString("X")}{blue.ToString("X")}");


                    Console.WriteLine("\nGenerated these names for this color:\n");
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }
                catch (InsufficientSourceDataException)
                {
                    Console.WriteLine("Not enough test data for that color. Trying again...");

                    attempts++;
                }
            }
        }
    }
}
