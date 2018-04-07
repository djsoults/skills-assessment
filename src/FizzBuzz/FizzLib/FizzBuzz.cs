using System;
using System.Collections.Generic;

namespace FizzLib
{
    public class FizzBuzz
    {
        public IDictionary<int, string> GetFizzBuzz(int min = 1, int max = 100)
        {
            var dictionary = new Dictionary<int, string>();

            for (var i = min; i < max; i++)
            {
                var value = "";
                value = value + GetFizz(i);
                value = value + GetBuzz(i);

                dictionary.Add(i, value);
            }

            return dictionary;
        }

        private static string GetFizz(int i)
        {
            return i % 3 == 0 ? "fizz" : i.ToString();
        }

        private static string GetBuzz(int i)
        {
            return i % 5 == 0 ? "buzz" : i.ToString();
        }
    }
}
