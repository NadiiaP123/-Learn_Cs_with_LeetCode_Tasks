using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task010ExcelSheetColumnTitle
    {
        public static void Run()
        {
            int columnNumber = 1605; //BIS

            var sb = new StringBuilder();

            while (columnNumber > 0)
            {
                columnNumber--;
                sb.Append((char)('A' + columnNumber % 26));
                columnNumber /= 26;

            }

            Console.WriteLine(sb.ToString().Reverse().ToArray());


       }
    }
}
