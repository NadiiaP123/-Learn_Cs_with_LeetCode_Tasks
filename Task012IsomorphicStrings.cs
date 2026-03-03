using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task012IsomorphicStrings
    {
        public static void Run()
        {
            //string s = "paper", t = "title"; //true
            string s = "foo", t = "bar"; //false

            int[] sChanged = new int[s.Length];
            int[] tChanged = new int[s.Length];
            int digit = 1;

            if (s.Length != t.Length)
            {
                Console.WriteLine(false);
                return;
            }

         for (int i = 0; i < s.Length; i++)
            {
                char sSymb = s[i];
                char tSymb = t[i];

                for (int j = 0; j < s.Length; j++)
                {

                    if (sChanged[j] != tChanged[j])
                    {
                        Console.WriteLine(false);
                        return;
                    }
                }
                
                digit++;
            }

            Console.WriteLine(string.Join(", ", sChanged));
            Console.WriteLine(string.Join(", ", tChanged));
            Console.WriteLine(true);
        }
    }
}
