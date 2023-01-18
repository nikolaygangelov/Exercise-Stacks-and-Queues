using System;
using System.Collections.Generic;
using System.Linq;
namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();

            Stack<char> stackOfChars = new Stack<char>();

            bool isBalanced = true;
            for (int i = 0; i < sequence.Length; i++)
            {
                char currentLetter = sequence[i];

                if (currentLetter == '{' || currentLetter == '[' || currentLetter == '(')
                {
                    stackOfChars.Push(currentLetter);
                }
                else if (currentLetter == '}')
                {
                    if(stackOfChars.Count == 0 || stackOfChars.Pop() != '{')
                    {
                        isBalanced = false;                       
                        break;
                    }
                }
                else if (currentLetter == ']')
                {
                    if (stackOfChars.Count == 0 || stackOfChars.Pop() != '[')
                    {
                        isBalanced = false;                       
                        break;
                    }
                }
                else if (currentLetter == ')')
                {
                    if (stackOfChars.Count == 0 || stackOfChars.Pop() != '(')
                    {
                        isBalanced = false;                      
                        break;
                    }
                }
            }

            if (stackOfChars.Count > 0)
            {
                isBalanced = false;
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
