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

            Func<int, int> cube = x => x * x * x;


            Console.WriteLine("Тестування підрахунку куба чисел:");

            int[] testNumbers = { 2, 3, 4, 5, 6 };

            foreach (var number in testNumbers)
            {
                Console.WriteLine($"Куб числа {number} = {cube(number)}");
            }
        }
    }
}


    