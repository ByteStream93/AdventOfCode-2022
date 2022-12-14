using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Day6
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("First part of day 6: ");
            part1();

            Console.WriteLine("Second part of day 6: ");
            part2();



        }

        static void part1()
        {

            var input = File.ReadAllLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day6\\Input6.txt");


            string temporaryString = "";
            int identic = -1;
            int stopPosition = 0;


            foreach (var line in input)
            {
                for (int positionIndex = 0; positionIndex < line.Length - 4; positionIndex++)
                {

                    var letters = new List<char>();

                    for (int actualIndex = positionIndex; actualIndex < positionIndex + 4; actualIndex++)
                    {
                        if (!letters.Contains(line[actualIndex]))
                        {
                            letters.Add(line[actualIndex]);


                            if (letters.Count == 4)
                            {
                                stopPosition++;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }

                    }


                    if (stopPosition != 0)
                    {
                        Console.WriteLine((positionIndex + 4).ToString());
                        break;
                    }







                }
            }
        }


        static void part2()
        {

            var input = File.ReadAllLines("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day6\\Input6.txt");


            string temporaryString = "";
            int identic = -1;
            int stopPosition = 0;


            foreach (var line in input)
            {
                for (int positionIndex = 0; positionIndex < line.Length - 14; positionIndex++)
                {

                    var letters = new List<char>();

                    for (int actualIndex = positionIndex; actualIndex < positionIndex + 14; actualIndex++)
                    {
                        if (!letters.Contains(line[actualIndex]))
                        {
                            letters.Add(line[actualIndex]);


                            if (letters.Count == 14)
                            {
                                stopPosition++;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }

                    }


                    if (stopPosition != 0)
                    {
                        Console.WriteLine((positionIndex + 14).ToString());
                        break;
                    }







                }
            }
        }
    }
}
    






