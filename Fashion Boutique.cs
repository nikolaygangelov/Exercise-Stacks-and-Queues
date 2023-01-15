﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(
                                 Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse));

            int rack = int.Parse(Console.ReadLine());

            int currentRack = rack;
            int numberOfRacks = 1;

            while (clothes.Any())
            {
                currentRack -= clothes.Peek();

                if (currentRack < 0)
                {
                    currentRack = rack;
                    numberOfRacks++;

                    continue;
                }

                clothes.Pop();
            }

            Console.WriteLine(numberOfRacks);

        }
    }
}
