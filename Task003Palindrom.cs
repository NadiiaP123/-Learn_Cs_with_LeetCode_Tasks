using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task003Palindrom
    {
        public static void Run()
        {
            int number = int.Parse(Console.ReadLine());
            string text = number.ToString();

            for (int i = 0; i <= text.Length / 2; i++)
            {
                if (text[i] != text[^(i+1)])
                {
                    Console.WriteLine(false);
                    return;
                }
            }

            Console.WriteLine(true);
        }

    }
}
