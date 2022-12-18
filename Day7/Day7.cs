using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Day7
    {

        public static void Main(string[] args)
        {

            //Console.WriteLine("First part of day 7: ");
            //part1();

            Console.WriteLine();

            Console.WriteLine("Second part of day 7: ");
            part2();


        }

        static void part1()
        {

            int capacitySum = 0;
            int folderCounter = 0;
            int orderEntered = 0;
            int fileCounter = 0;
            int totalSum = 0;


            var input = File.ReadLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day7\\Input7.txt");

            var commands = new List<string>(input);


            foreach (var line in commands)
            {
                if (line.Substring(0, 1) != "$")
                {

                    if (line.Substring(0, 3) == "dir")
                    {
                        Console.WriteLine("opened Folder");
                        if (capacitySum <= 100000 && orderEntered == 1)
                        {

                            folderCounter++;
                            totalSum += capacitySum;
                            capacitySum = 0;
                            orderEntered = 0;

                        }
                    }
                    else
                    {
                        var splittedLine = line.Split(' ');
                        capacitySum += Int32.Parse(splittedLine[0]);
                        orderEntered = 1;
                        fileCounter++;
                        Console.WriteLine("SpaceData: " + splittedLine[0] + " Counted: " + folderCounter + " FilesFound: " + fileCounter);
                    }

                }
                else
                {
                    capacitySum = 0;
                }
            }
            Console.WriteLine(totalSum);

        }
        static void part2()
        {
            int capacitySum = 0;
            int enteredFile = 0;
            int totalSum = 0;


            var input = File.ReadLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\Day7\\Input7.txt");

            var commands = new List<string>(input);
            var results = new List<int>();
           

            foreach (var line in commands)

            {
                if (line.Substring(0, 4) == "$ ls")
                {

                    enteredFile = 1;


                }
                if (line.Substring(0, 4) == "$ cd")
                {
                    if (capacitySum < 100000)
                    {
                        Console.WriteLine(capacitySum);
                        totalSum += capacitySum;
                        
                    }
                    enteredFile = 0;
                    capacitySum = 0;

                }
                if (enteredFile == 1 && line.Substring(0, 1) != "$")
                {
                    if (enteredFile == 1 && line.Substring(0, 3) != "dir")
                    {
                        var splittedLine = line.Split(' ');


                        if (!(splittedLine[0].Contains("$")) || !splittedLine[0].Contains("dir"))
                        {
                            
                            int num = Int32.Parse(splittedLine[0]);
                            capacitySum += num;
                        }
                    }
                }


            }
            Console.WriteLine();
            Console.WriteLine(totalSum);

        }


    }
}
