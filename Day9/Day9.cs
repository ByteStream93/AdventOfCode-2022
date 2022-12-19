using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Day9
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("First part of day 9: ");
            part1();

            Console.WriteLine();

        }

        static void part1()
        {
            var inputText = File.ReadAllLines("C:\\Users\\herzo\\Source\\Repos\\ByteStream93\\AdventOfCode-2022\\Day9\\Input9.txt");

            var input = new List<string>(inputText);

            ArrayList positions = new ArrayList();

            int head_x = 0;
            int head_y = 0;

            int tail_x = 0;
            int tail_y = 0;

            Console.WriteLine(tail_x + " " + tail_y);
            foreach (var line in input)
            {
                var direction = line.Split(" ");

                for (int move = 0; move < Int32.Parse(direction[1]); move++){

                    if (direction[0] == "U")
                    {
                        head_y--;
                    }
                    else if (direction[0] == "D")
                    {
                        head_y++;
                    }
                    else if (direction[0] == "L")
                    {
                        head_x--;
                    }
                    else if (direction[0] == "R")
                    {
                        head_x++;
                    }

                    if (!(Math.Abs(head_x - tail_x) <= 1) && !(Math.Abs(head_y - tail_y) == 1))
                    {

                        if (head_x > tail_x)
                        {
                            tail_x += 1;
                        }
                        else if (head_x < tail_x)
                        {
                            tail_x -= 1;
                        }
                        if (head_y > tail_y)
                        {
                            tail_y += 1;
                        }
                        else if (head_y < tail_y)
                        {
                            tail_y -= 1;
                        }

                        Console.WriteLine(tail_x + " " + tail_y);
                        positions.Insert(tail_x, tail_y);
                        

                    }

                }

            }
            Console.WriteLine(positions.Count);
            
            }


        }

    }


