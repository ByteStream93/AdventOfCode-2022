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

            Console.WriteLine("First part of day 7: ");
            part1();

            Console.WriteLine();

            Console.WriteLine("Second part of day 7: ");
            part2();


        }

        static void part1()
        {

            var input = File.ReadLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\Day7\\Input7.txt");

            var row = new List<string>(input);

            var currentDirectory = new List<string>();

            string createCurrentDirectory()
            {
                string dir = string.Join("/", currentDirectory);
                dir = dir.Replace("//", "/");
                return dir;
            }

            var dictionarySize = new Dictionary<string, int>();

            foreach (var line in row)
            {
                if (line.Substring(0, 1) == "$")
                {
                    var command = line.Split(" ");

                    if (command[1] == "cd")
                    {
                        if (command[2] == "..")
                        {
                            currentDirectory.RemoveAt(currentDirectory.Count - 1);
                        }
                        else
                        {
                            currentDirectory.Add(command[2]);
                        }
                    }
                }
                else if (line.Substring(0, 3) != "dir")
                {
                    var file = line.Split(" ");
                    if (!dictionarySize.ContainsKey(createCurrentDirectory()))
                    {
                        dictionarySize[createCurrentDirectory()] = 0;
                    }
                    string dir = createCurrentDirectory();
                    while (dir.Contains("/"))
                    {
                        if (!dictionarySize.ContainsKey(dir))
                        {
                            dictionarySize[dir] = 0;
                        }
                        dictionarySize[dir] += Convert.ToInt32(file[0]);

                        if (dir == "/") break;

                        var dirSplit = dir.Split("/").ToList();
                        dirSplit.RemoveAt(dirSplit.Count - 1);
                        dir = string.Join("/", dirSplit);
                    }
                }
            }

            int output = 0;

            foreach (var item in dictionarySize)
            {
                if (item.Value <= 100000)
                {
                    output += item.Value;
                }
            }

            Console.WriteLine(output);
        }

        static void part2()
        {


        }
    }
}


