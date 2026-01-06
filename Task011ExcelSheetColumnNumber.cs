using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task011ExcelSheetColumnNumber
    {
        public static void Run()
        {
            string columnTitle = "ADO";  //795

            int result = 0;

            foreach (char i in columnTitle)
            {
                int number = i - 'A' + 1;
                result = result * 26 + number;
            }

            Console.WriteLine(result);
        }
    }
}
