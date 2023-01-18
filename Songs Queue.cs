using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                             .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songList = new Queue<string>(songs);

            while (songList.Any())
            {
                string commands = Console.ReadLine();

                string commandType = commands.Substring(0, 4);
                if (commandType == "Play")
                {
                    songList.Dequeue();

                }
                else if (commandType == "Add ")
                {
                    string songToAdd = string.Join(' ', commands.Skip(1));
                    if (!songList.Contains(songToAdd))
                    {
                        songList.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }

                }
                else if (commandType == "Show")
                {
                    Console.WriteLine(string.Join(", ", songList));
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
