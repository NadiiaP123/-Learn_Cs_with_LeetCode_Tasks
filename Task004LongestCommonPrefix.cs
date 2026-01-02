using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetcodeTasks
{
    internal class Task004LongestCommonPrefix
    {
        public static void Run()
        {
            string[] strs = ["flower", "flow", "flight"];
            

            for (int i = 0; i < strs[0].Length; i++)
            {
                char letter = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i > strs[j].Length  || strs[j][i] != letter)
                    {
                        Console.WriteLine(strs[0][0..i]);
                        return;
                    }
                }

            }

            Console.WriteLine("");
        }
    }
}
