using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task008AddBinary
    {
        public static void Run()
        {
            string a = "1010";
            string b = "1011";

            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);

            int len = a.Length >= b.Length ? a.Length : b.Length;

            int k = 1;
            int carry = 0;
            var sb = new StringBuilder();

            for (int i = len - 1; i >= 0; i--)
            {
                char aChar = k > a.Length ? '0' : a[^k];
                char bChar = k > b.Length ? '0' : b[^k];

                if (aChar == '0' && bChar == '0' && carry == 0)
                {
                    sb.Append('0');
                    carry = 0;
                }

                else if ((aChar == '1' && bChar == '0' && carry == 0) || (aChar == '0' && bChar == '1' && carry == 0) || (aChar == '0' && bChar == '0' && carry == 1))
                {
                    sb.Append('1');
                    carry = 0;
                }

                else if ((aChar == '1' && bChar == '1' && carry == 0) || (aChar == '0' && bChar == '1' && carry == 1) || (aChar == '1' && bChar == '0' && carry == 1))
                {
                    sb.Append('0');
                    carry = 1;
                }

                else
                {
                    sb.Append('1');
                    carry = 1;
                }

                k++;
            }

            if (carry == 1)
            {
                sb.Append('1');
            }



            char[] arr = sb.ToString().ToCharArray();
            Array.Reverse(arr);
            string result = new string(arr);

            Console.WriteLine(result);
        }
    }
}
