using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Day3
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("First part of day3: ");
            part1();

            Console.WriteLine();

            Console.WriteLine("Second part of day3: ");

        }


        public static void part1()
        {
            var inputLines = File.ReadAllLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day3\\Input3.txt");
            var input = new List<string>(inputLines);
            var characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
            int valueOfLetters = 0;

            
            foreach(var line in input)
            {
                var firstHalfRucksack = line.Substring(0, line.Length/2);
                var secondHalfRucksack = line.Substring(line.Length / 2, line.Length/2);

                foreach(var x in secondHalfRucksack)
                {
                    if (firstHalfRucksack.Contains(x))
                    {
                        valueOfLetters += Array.IndexOf(characters, x) + 1;
                        break;
                    }
                }
            }

            Console.WriteLine(valueOfLetters.ToString());

        }

    }
}
