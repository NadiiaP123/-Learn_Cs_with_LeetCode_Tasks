using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetcodeTasks
{
    internal class Task001RomanToIntREGEX
    {
        public static void Run()
        {
            string roman = Console.ReadLine();

            ArgumentNullException.ThrowIfNull(roman);

            int number = 0;

            number += (Regex.Count(roman, "CM")) * 900;
            number += (Regex.Count(roman, "CD")) * 400;
            number += (Regex.Count(roman, "XC")) * 90;
            number += (Regex.Count(roman, "XL")) * 40;
            number += (Regex.Count(roman, "IV")) * 4;
            number += (Regex.Count(roman, "IX")) * 9;

            roman = Regex.Replace(roman, "CM|CD|XC|XL|IV|IX", "");

            number += (Regex.Count(roman, "I")) * 1;
            number += (Regex.Count(roman, "V")) * 5;
            number += (Regex.Count(roman, "X")) * 10;
            number += (Regex.Count(roman, "L")) * 50;
            number += (Regex.Count(roman, "C")) * 100;
            number += (Regex.Count(roman, "D")) * 500;
            number += (Regex.Count(roman, "M")) * 1000;

            Console.WriteLine(number);

        }
    }
}
