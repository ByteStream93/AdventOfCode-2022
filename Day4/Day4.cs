using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Day4
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("First part of day4: ");
            part1();

            Console.WriteLine();

            Console.WriteLine("Second part of day4: ");
            part2();

        }

        public static void part1()
        {
           var lines = File.ReadAllLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day4\\Input4.txt");
            
           var input = new List<string>(lines);

            int overlappingCounter = 0;
            
            foreach(var line in input)
            {
                var cleanArea = line.Split(",");

                var firstElve = cleanArea[0].Split("-");
                var secondElve = cleanArea[1].Split("-");






                if (Int32.Parse(firstElve[0]) <= Int32.Parse(secondElve[0]) && Int32.Parse(firstElve[1]) >= Int32.Parse(secondElve[1]) || 
                    Int32.Parse(firstElve[0]) >= Int32.Parse(secondElve[0]) && Int32.Parse(firstElve[1]) <= Int32.Parse(secondElve[1]))
                {
                    overlappingCounter++;
                }

            }
            Console.WriteLine(overlappingCounter);
            
        }

        public static void part2() {
            var lines = File.ReadAllLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day4\\Input4.txt");

            var input = new List<string>(lines);

            int overlappingCounter = 0;

            foreach (var line in input)
            {
                var cleanArea = line.Split(",");

                var firstElve = cleanArea[0].Split("-");
                var secondElve = cleanArea[1].Split("-");






                if (Int32.Parse(firstElve[0]) <= Int32.Parse(secondElve[1]) && Int32.Parse(firstElve[1]) >= Int32.Parse(secondElve[0])) 
                {
                    overlappingCounter++;
                }

            }
            Console.WriteLine(overlappingCounter);

        }

    }
}
