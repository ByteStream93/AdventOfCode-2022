using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Day5
    {

        /*

        [N]     [C]                 [Q]    
        [W]     [J] [L]             [J] [V]
        [F]     [N] [D]     [L]     [S] [W]
        [R] [S] [F] [G]     [R]     [V] [Z]
        [Z] [G] [Q] [C]     [W] [C] [F] [G]
        [S] [Q] [V] [P] [S] [F] [D] [R] [S]
        [M] [P] [R] [Z] [P] [D] [N] [N] [M]
        [D] [W] [W] [F] [T] [H] [Z] [W] [R]
         1   2   3   4   5   6   7   8   9 

        */


        public static void Main(string[] args)
        {



            Console.WriteLine("First part of day 5: ");
            part1();

            Console.WriteLine();

            Console.WriteLine("Second part of day 5: ");
            part2();

        }     

        static void part1()
        {
            var stack = new List<string>[9] {

            new List<string>() { "D", "M", "S", "Z", "R", "F", "W", "N" },
            new List<string>() { "W", "P", "Q", "G", "S" },
            new List<string>() { "W", "R", "V", "Q", "F", "N", "J", "C" },
            new List<string>() { "F", "Z", "P", "C", "G", "D", "L" },
            new List<string>() { "T", "P", "S" },
            new List<string>() { "H", "D", "F", "W", "R", "L" },
            new List<string>() { "Z", "N", "D", "C" },
            new List<string>() { "W", "N", "R", "F", "V", "S", "J", "Q" },
            new List<string>() { "R", "M", "S", "G", "Z", "W", "V" },
        };


            var moves = File.ReadAllLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day5\\Input5.txt");

            foreach (var move in moves)
            {
                var numbers = move.Split("-");

                int amount = Int32.Parse(numbers[1]);
                int from = (Int32.Parse(numbers[2])) - 1;
                int to = Int32.Parse((numbers[3])) - 1;


                var actual = stack[from];

                for (int i = 1; i <= amount; i++)
                {

                    var piece = actual[actual.Count - 1];
                    stack[to].Add(piece);
                    actual.RemoveAt(actual.Count - 1);
                }
            }

            string result = "";

            foreach (var place in stack)
            {
                result += place[place.Count - 1];

            }
            Console.WriteLine(result);


        }

        static void part2()
        {
            var stack = new List<string>[9] {

            new List<string>() { "D", "M", "S", "Z", "R", "F", "W", "N" },
            new List<string>() { "W", "P", "Q", "G", "S" },
            new List<string>() { "W", "R", "V", "Q", "F", "N", "J", "C" },
            new List<string>() { "F", "Z", "P", "C", "G", "D", "L" },
            new List<string>() { "T", "P", "S" },
            new List<string>() { "H", "D", "F", "W", "R", "L" },
            new List<string>() { "Z", "N", "D", "C" },
            new List<string>() { "W", "N", "R", "F", "V", "S", "J", "Q" },
            new List<string>() { "R", "M", "S", "G", "Z", "W", "V" },
        };
            

            var moves = File.ReadAllLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day5\\Input5.txt");

            foreach (var move in moves)
            {
                var numbers = move.Split("-");

                var amount = Int32.Parse(numbers[1]);
                var from = (Int32.Parse(numbers[2])) - 1;
                var to = Int32.Parse((numbers[3])) - 1;


                var actual = stack[from];

                var newList = new List<string>();

                for (int i = 1; i <= amount; i++)
                {
                    var piece = actual[actual.Count - 1];
                    newList.Add(piece);
                    actual.RemoveAt(actual.Count - 1);                   
                }

                newList.Reverse();

                foreach (var piece in newList)
                {
                    stack[to].Add(piece);

                }

            }

            string result = "";

            foreach (var place in stack)
            {
                result += place[place.Count - 1];

            }
            Console.WriteLine(result);


        }
    }
}



    

