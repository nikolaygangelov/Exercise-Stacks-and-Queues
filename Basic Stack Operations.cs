using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
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

            Stack<int> stack = new Stack<int>(input2);

            for (int i = 1; i <= input1[1]; i++)
            {
                stack.Pop();
            }

            if (!stack.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                if (stack.Contains(input1[2]))
                {
                    Console.WriteLine("true");
                }
                else if (!stack.Contains(input1[2]))
                {
                    Console.WriteLine(stack.Min());
                }
            }

            

            

        }
    }
}
