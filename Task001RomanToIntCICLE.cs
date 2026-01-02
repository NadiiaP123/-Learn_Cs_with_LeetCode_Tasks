using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetcodeTasks
{
    internal class Task001RomanToIntCICLE
    {
        public static void Run()
        {
            string roman = Console.ReadLine();
            int number = 0;

            ArgumentNullException.ThrowIfNull(roman);

            var map = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };


            for (int i = 0; i < roman.Length; i++)
            {
                int current = map[roman[i]];
                int next = (i + 1 < roman.Length) ? map[roman[i + 1]] : 0;

                if (current < next)
                {
                    number -= current;
                }
                else
                {
                    number += current;
                }
            }

            Console.WriteLine(number);
        }

    }
}
