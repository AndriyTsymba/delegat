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
            Func<int[], int> countMultiplesOfSeven = arr => arr.Count(x => x % 7 == 0);
            int[] numbers = { 7, 14, 21, 9, 28, 35, 3, 18 };
            Console.WriteLine("Кількість чисел, кратних 7: " + countMultiplesOfSeven(numbers));
        }
    }
}
