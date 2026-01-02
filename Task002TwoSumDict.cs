using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTasks
{
    internal class Task002TwoSumDict
    {
        public static void Run()
        {
            string input = Console.ReadLine();
            int target = int.Parse(Console.ReadLine());

            ArgumentNullException.ThrowIfNull(input);

            int[] nums = input
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var map = new Dictionary<int, int>(capacity: nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                int need = target - nums[i];

                if (map.TryGetValue(need, out int j))
                {
                    Console.WriteLine($"{j}, {i}");
                    return;
                    //return new[] { j, i };
                }

                map[nums[i]] = i;
            }

            Console.WriteLine(false);
        }
    }
}
