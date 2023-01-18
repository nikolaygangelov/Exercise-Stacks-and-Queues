using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfOperations = int.Parse(Console.ReadLine());

            string text = string.Empty;
            Stack<string> stack = new Stack<string>();
            stack.Push(text);
            
            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] inputParameters = Console.ReadLine().Split();
                char commandNumber = char.Parse(inputParameters[0]);

                if (commandNumber == '1')
                {
                    string textToAppend = inputParameters[1];
                    string currentStack = stack.Peek();
                    currentStack += textToAppend;
                    stack.Push(currentStack);
                    
                }
                else if (commandNumber == '2')
                {
                    int countToErase = int.Parse(inputParameters[1]);
                    string currentStack = stack.Peek();
                    currentStack = currentStack.Remove(currentStack.Length - countToErase, countToErase);
                    stack.Push(currentStack);
                    
                }
                else if (commandNumber == '3')
                {
                    int positionOfElement = int.Parse(inputParameters[1]);
                    Console.WriteLine(stack.Peek()[positionOfElement - 1]);
                    
                }
                else if (commandNumber == '4')
                {
                    stack.Pop();
                }
            }
        }
    }
}
