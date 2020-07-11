using System;
using System.Collections.Generic;
using System.Linq;

namespace WallEGarbageCollector
{
    public class WallEGarbageCollector
    {
        public static int counter = 0; // set counter 

        public static void Main(string[] args)
        {
            while (true) // Loop indefinitely
            {
                Console.WriteLine("Welcome to Wall-E Garbage Collector Program");
                Console.WriteLine("[Note: Q exit the program]");
                Console.WriteLine();
                Console.WriteLine(">Please enter the Directions of movement (N=North, S=South, E=East, O=West) :"); // Prompt

                string directions = Console.ReadLine(); // Get string from user

                if (directions == "Q") // Check string
                {
                    break; // Loop break
                }

                CollectGarbage(directions);
            }
        }

        public static string CollectGarbage(string input)
        {
            string output = string.Empty; // Create string to output retrieve
            string directions = input; // Get string from user input

            string[] directionsAllowed = { "N", "S", "E", "O" }; // Create and initialize array of allowed values

            List<Tuple<int, int>> MemoryPositions = new List<Tuple<int, int>>(); // create a List of Tuple<int, int>

            int x = 0;
            int y = 0;

            SavePos(MemoryPositions, x, y); // Save (0,0) position

            foreach (char value in directions) // iterate over directions of user prompt
            {
                if (directionsAllowed.Any(x => x == value.ToString())) // verify allowed values
                {
                    // Process...
                    if (value == 'N')
                    {
                        y++;
                        SavePos(MemoryPositions, x, y);
                    }

                    if (value == 'S')
                    {
                        y--;
                        SavePos(MemoryPositions, x, y);
                    }

                    if (value == 'E')
                    {
                        x++;
                        SavePos(MemoryPositions, x, y);
                    }

                    if (value == 'O')
                    {
                        x--;
                        SavePos(MemoryPositions, x, y);
                    }
                }
                else
                {
                    Console.WriteLine($"There is an invalid input with value '{value}'."); // verify disallowed inputs
                }
            }

            output = $"Collected: {counter}";
            Console.WriteLine(output);

            foreach (var t in MemoryPositions) // print memory positions
            {
                Console.WriteLine($"Positions: {t.ToValueTuple()}");
            }
            counter = 0; // restart counter
            Console.WriteLine("===========================================");
            Console.WriteLine();

            return output;
        }

        public static void SavePos(List<Tuple<int, int>> MemoryPositionsTuple, int i, int j)
        {
            bool alreadyExist = MemoryPositionsTuple.Contains(new Tuple<int, int>(i, j)); // verify if position already exist in list of Positions

            if (!alreadyExist)
            {
                // add an item
                MemoryPositionsTuple.Add(new Tuple<int, int>(i, j));
                counter++;
            }

        }
    }
}
