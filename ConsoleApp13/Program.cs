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

            Func<int, int> square = delegate (int number)
            {
                return number * number;
            };


            Console.WriteLine("Тестування підрахунку квадрата чисел:");

            int[] testNumbers = { 3, 7, 5, 10, 15 };

            foreach (var number in testNumbers)
            {
                Console.WriteLine($"Квадрат числа {number} = {square(number)}");
            }
        }
    }
}
    

    