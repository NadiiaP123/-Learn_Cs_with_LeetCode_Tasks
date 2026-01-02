using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace LeetcodeTasks
{
    internal class Task005ValidParentheses
    {
        public static void Run()
        {
            string input = "(){((})}{}";

            ArgumentNullException.ThrowIfNull(input);

            if (input.Length % 2 != 0)
            {
                Console.WriteLine (false);
                return;
            }

            var stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine(false);
                        return;
                    }

                    char open = stack.Pop();

                    if ((c == ')' && open != '(') || (c == '}' && open != '{') || (c == ']' && open != '['))
                    {
                        Console.WriteLine (false);
                        return;
                    }
                }
            }

            Console.WriteLine(stack.Count == 0);
        }
    }
}
