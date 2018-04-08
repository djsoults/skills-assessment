using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzLib;

namespace FizzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();

            Console.WriteLine("Running from 1 to 100");
            Console.WriteLine();
            var defaultRun = fizzBuzz.GetFizzBuzz();
            PrintValues(defaultRun);

            Console.WriteLine(@"Press Enter To Close...");
            Console.ReadLine();
        }

        private static void PrintValues(IDictionary<int, string> run)
        {
            foreach (var row in run)
            {
                Console.WriteLine($"{row.Key}: {row.Value}");
            }
        }
    }
}
