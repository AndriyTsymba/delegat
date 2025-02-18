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
            Func<int[], int> findMax = arr => arr.Min();
            int[] numbers = { 12, 5, 8, 20, 6, 15 };
            Console.WriteLine("Мінімум в масиві: " + findMax(numbers));
        }
    }
}
  
    