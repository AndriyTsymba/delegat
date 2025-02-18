using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{

    internal class Program
    {
        static void Main()
        {

            Func<int[], int> countPositiveNumbers = arr => arr.Count(x => x > 0);
            int[] numbers = { 7, -2, 14, 0, -3, 18, 5 };
            Console.WriteLine("Кількість позитивних чисел: " + countPositiveNumbers(numbers));
        }
    }
}