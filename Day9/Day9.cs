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

            Console.WriteLine("Second part of day 9: ");
            part2();

        }

        static void part1()
        {
            var inputText = File.ReadAllLines("C:\\Users\\herzo\\Source\\Repos\\ByteStream93\\AdventOfCode-2022\\Day9\\Input9.txt");

            var input = new List<string>(inputText);

            var positions = new HashSet<string>();
            

            int head_x = 0;
            int head_y = 0;

            int tail_x = 0;
            int tail_y = 0;

            

            
            foreach (var line in input)
            {
                var direction = line.Split(" ");

                for (int move = 0; move < Int32.Parse(direction[1]); move++) {


                    //Console.WriteLine(direction[0]);

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

                    if (!(Math.Abs(head_x - tail_x) <= 1) || !(Math.Abs(head_y - tail_y) <= 1))
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

                        
                    }

                    positions.Add(addPosition(tail_x, tail_y));
                }

            }
            Console.WriteLine(positions.Count);

        }

        static void part2()
        {
            var inputText = File.ReadAllLines("C:\\Users\\herzo\\Source\\Repos\\ByteStream93\\AdventOfCode-2022\\Day9\\TextFile1.txt");

            var input = new List<string>(inputText);

            var positions = new HashSet<string>();


           int head_x = 0;
           int head_y = 0;

            var tail_x = new int[9];
            var tail_y = new int[9];




            foreach (var line in input)
            {
                var direction = line.Split(" ");

                for (int move = 0; move < Int32.Parse(direction[1]); move++)
                {


                    //Console.WriteLine(direction[0]);

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

                    if (!(Math.Abs(head_x - tail_x[0]) <= 1) || !(Math.Abs(head_y - tail_y[0]) <= 1))
                    {

                        if (head_x > tail_x[0])
                        {
                            tail_x[0] += 1;
                        }
                        else if (head_x < tail_x[0])
                        {
                            tail_x[0] -= 1;
                        }
                        if (head_y > tail_y[0])
                        {
                            tail_y[0] += 1;
                        }
                        else if (head_y < tail_y[0])
                        {
                            tail_y[0] -= 1;
                        }

                    }

                    for (int tailPosition = tail_x.Length-1; tailPosition > 0; tailPosition--) {
                                             
                        
                            if (tail_x[tailPosition] != tail_x[tailPosition - 1] || tail_y[tailPosition] != tail_y[tailPosition - 1])
                            {
                                tail_x[tailPosition] = tail_x[tailPosition - 1];
                                tail_y[tailPosition] = tail_y[tailPosition - 1];
                            }
                        
                        Console.WriteLine("TailIndex:" + tailPosition + " x:" + tail_x[tailPosition] + " y:" + tail_y[tailPosition]);
                        if (tailPosition == 8)
                        {
                            Console.WriteLine();
                        }
                        
                        positions.Add(addPosition(tail_x[8], tail_y[8]));
                    }
                    
                    

                }

            }
            Console.WriteLine(positions.Count);
        }


        static string addPosition(int x_coordinate, int y_coordinate)
        {

            return $"{x_coordinate.ToString()},{y_coordinate.ToString()}";

        }

      
    
        }

    }


