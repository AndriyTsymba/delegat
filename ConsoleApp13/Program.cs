using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, (int, int, int)> getRgbValue = delegate (string color)
            {
                switch (color.ToLower())
                {
                    case "red":
                        return (255, 0, 0);  
                    case "orange":
                        return (255, 165, 0); 
                    case "yellow":
                        return (255, 255, 0); 
                    case "green":
                        return (0, 255, 0);  
                    case "blue":
                        return (0, 0, 255);   
                    case "indigo":
                        return (75, 0, 130);  
                    case "violet":
                        return (238, 130, 238); 
                    default:
                        return (0, 0, 0);   
                }
            };
            Console.WriteLine("Тестування RGB значень для кольорів веселки:");

            string[] rainbowColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

            foreach (var color in rainbowColors)
            {
                var (r, g, b) = getRgbValue(color);
                Console.WriteLine($"RGB для {color}: ({r}, {g}, {b})");
            }
        }
    }
}

    