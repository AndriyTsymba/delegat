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

            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            Console.WriteLine("Тестування парності чисел:");

            int[] testNumbers = { 10, 15, 22, 33, 42 };

            foreach (var number in testNumbers)
            {
                Console.WriteLine($"Число {number} {(isEven(number) ? "парне" : "непарне")}");
            }
        }
    }
}
    

