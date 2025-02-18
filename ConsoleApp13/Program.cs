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
            Func<string, string, bool> containsWord = (text, word) => text.Contains(word);
            string text = "Це простий тестовий текст для перевірки.";
            string wordToFind = "тестовий";
            bool result = containsWord(text, wordToFind);
            Console.WriteLine($"Текст містить слово '{wordToFind}': {result}");
        }
    }
}