using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task006IndexOfFirstOccurence
    {
        public static void Run()
        {
            string haystack = "sadbutsad";
            string needle = "but";

            ArgumentNullException.ThrowIfNull(haystack);
            ArgumentNullException.ThrowIfNull(needle);

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i..(i + (needle.Length))] == needle)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
