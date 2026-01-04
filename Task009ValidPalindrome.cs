using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task009ValidPalindrome
    {
        public static void Run()
        {
            string s = "A man, a plan, a canal: Panama";
            ArgumentNullException.ThrowIfNull(s);

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left])) left++;
                while (left < right && !char.IsLetterOrDigit(s[right])) right--;

                if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                {
                    Console.WriteLine(false);
                    return;
                }

                left++;
                right--;
            }

            Console.WriteLine(true);

        }
    }
}
