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
            Func<DateTime, bool> isProgrammersDay = date =>
            {
                int year = date.Year;
                DateTime programmersDay = new DateTime(year, 1, 1).AddDays(255);

                return date.Date == programmersDay.Date;
            };
            Console.WriteLine("Тестування дня програміста:");
            DateTime[] testDates = {
            new DateTime(2025, 9, 13), 
            new DateTime(2025, 9, 14), 
            new DateTime(2024, 9, 12), 
            new DateTime(2023, 9, 13)
            };
            foreach (var date in testDates)
            {
                Console.WriteLine($"{date.ToString("yyyy-MM-dd")} є днем програміста: {isProgrammersDay(date)}");
            }
        }
    }
}
    