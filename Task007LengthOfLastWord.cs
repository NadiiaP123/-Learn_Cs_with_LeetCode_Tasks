using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task007LengthOfLastWord
    {
        public static void Run()
        {
            string s = "   fly me   to   the mooooon  ";
        
            ArgumentNullException.ThrowIfNull(s);
            int count = 0;

            for (int i = s.Length - 1; i > 0; i--)
            {
                if (s[i] != ' ' && s[i - 1] == ' ')
                {
                    break;
                }

                if (s[i] != ' ')
                {
                    count++;
                }
            }

            Console.WriteLine(count + 1 );

        }
    }
}
