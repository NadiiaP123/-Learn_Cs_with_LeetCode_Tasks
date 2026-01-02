using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task002TwoSum
    {

        public static void Run()
        {
            string input = Console.ReadLine();
            int target = int.Parse(Console.ReadLine());
            int[] result = { 0, 0 };

            ArgumentNullException.ThrowIfNull(input);

            int[] nums= input
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i) continue;
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"{i}, {j}");
                        return;
                    }
                }
            }

            Console.WriteLine(result);
        }
        
    }
}
