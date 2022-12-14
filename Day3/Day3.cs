using System;
using System.Collections.Generic;
using System.Data;
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
            part2();
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

        public static void part2()
        {
            var inputLines = File.ReadAllLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day3\\Input3.txt");
            var input = new List<string>(inputLines);
            var characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
            int valueOfLetters = 0;

            int rowCount = 0;
            var line = new String[3];

            foreach(var row in input)
            {
                if(rowCount < 3)
                {
                    line[rowCount] = row;
                    rowCount++;
                }

                if (rowCount == 3)
                {
                    var match = new List<char>();

                    foreach (var x in line[1])
                    {
                        if (line[0].Contains(x))
                        {
                            match.Add(x);
                        }
                    }
                    foreach(var y in line[2])
                    {
                        if (match.Contains(y))
                        {
                            valueOfLetters += Array.IndexOf(characters, y) + 1;
                            break;
                        }
                    }
                    line = new String[3];
                    rowCount = 0;
                }
            }
          

            Console.WriteLine(valueOfLetters.ToString());
        }

    }
}
