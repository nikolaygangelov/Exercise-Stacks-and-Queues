using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Queue<int> queue = new Queue<int>(input2);

            for (int i = 1; i <= input1[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Any())
            {

                if (queue.Contains(input1[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }

            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
