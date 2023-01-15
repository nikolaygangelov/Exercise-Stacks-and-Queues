using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {

            int foodQuantity = int.Parse(Console.ReadLine());
            int[] ordersQuantity = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(ordersQuantity);
            Console.WriteLine(orders.Max());

            for (int i = 0; i < ordersQuantity.Length; i++)
            {
                if (orders.Count == 0)
                {
                    break;
                }
                if ((foodQuantity - orders.Peek()) <= 0)
                {
                    break;
                }
                foodQuantity -= orders.Dequeue();
            }

            if (orders.Count == 0 || (orders.Count == 0 && foodQuantity == 0))
            {
                Console.WriteLine($"Orders complete");
            }
            else if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            }

        }
    }
}
