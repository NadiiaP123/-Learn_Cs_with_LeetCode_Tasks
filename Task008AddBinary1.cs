using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task008AddBinary1
    {
        public static void Run()
        {
            string a = "11";
            string b = "1";

            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);

            int len = a.Length >= b.Length ? a.Length : b.Length;

            int k = 1;
            bool carry = false;
            var sb = new StringBuilder();

            for (int i = len - 1; i >= 0; i--)
            {
                bool aBool = k > a.Length ? false : (a[^k] == '1' ? true : false);
                bool bBool = k > b.Length ? false : (b[^k] == '1' ? true : false);

                if ((aBool && bBool && !carry) || (!aBool && bBool && carry) || (aBool && !bBool && carry) || (aBool && bBool && carry))
                {
                    carry = true;
                }
                else
                {
                    carry = false;
                }
                 
                sb.Append((aBool ^ bBool ^ carry ^ (aBool && bBool && carry))  ? 0 : 1);

            }

            var result = new StringBuilder();

            if (carry)
            {
                result.Append('1');
            }

            result.Append(sb);

            Console.WriteLine(result);
        }
    }
}
