using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfQueries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= numberOfQueries; i++)
            {
                
                int[] inputParameters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int commandType = inputParameters[0];
                if (commandType == 1)
                {

                    int elementToPush = inputParameters[1];
                    stack.Push(elementToPush);
                    
                }
                else if (commandType == 2)
                {
                    if (stack.Count() == 0)
                    {
                        continue;
                    }
                    stack.Pop();
                }
                else if (commandType == 3)
                {

                    if (stack.Count() == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(stack.Max());

                }
                else if (commandType == 4)
                {

                    if (stack.Count() == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(stack.Min());

                }

            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
