using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task003PalindromWithoutConverting
    {
        public static void Run()
        {
            int original = int.Parse(Console.ReadLine());
            int reversed = 0;
            int x = original;

            while (x > 0)
            {
                int lastDigit = x % 10;
                reversed = (reversed * 10) + lastDigit;
                x /= 10;
            
            }

            Console.WriteLine(original == reversed);
        }

    }
}
