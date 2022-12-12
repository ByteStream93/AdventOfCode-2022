using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Day2
    {
        /*
         * Rock is      A = Opponent            X = me  round with rock = 1         lose = 0    draw = 3    win = 6
           Paper is     B = Opponent            Y = me  round with paper = 2        lose = 0    draw = 3    win = 6
           Scissor is   C = Opponent            Z = me  round with scissor = 3      lose = 0    draw = 3    win = 6          
    
         */
        


        public static void Main(string[] args)
        {
            Console.WriteLine("First part of day2 score: ");
            part1();
            Console.WriteLine();

            Console.WriteLine("Second part of day2 score: ");
            part2();


        }


        public static void part1()
        {
        int totalscore = 0;
        String row = "";

            StreamReader streamreader = new StreamReader("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day2\\Input2.txt");

            while (row != null) 
            {
                row = streamreader.ReadLine();

                if (row != null)
                {
                    if (row.StartsWith("A"))
                    {
                        if (row.EndsWith("X"))
                        {
                            totalscore += 4;
                        }
                        if (row.EndsWith("Y"))
                        {
                            totalscore += 8;
                        }
                        if (row.EndsWith("Z"))
                        {
                            totalscore += 3;
                        }
                    }
                    if (row.StartsWith("B"))
                    {
                        if (row.EndsWith("X"))
                        {
                            totalscore += 1;
                        }
                        if (row.EndsWith("Y"))
                        {
                            totalscore += 5;
                        }
                        if (row.EndsWith("Z"))
                        {
                            totalscore += 9;
                        }
                    }
                    if (row.StartsWith("C"))
                    {
                        if (row.EndsWith("X"))
                        {
                            totalscore += 7;
                        }
                        if (row.EndsWith("Y"))
                        {
                            totalscore += 2;
                        }
                        if (row.EndsWith("Z"))
                        {
                            totalscore += 6;
                        }
                    }
                }
                if (row == null)
                {
                    break;
                }
            } 
            Console.WriteLine(totalscore);


        }

        public static void part2()
        {
            int totalscore = 0;
            String row = "";
           
            

            StreamReader streamreader = new StreamReader("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode-2022\\AdventOfCode-2022\\Day2\\Input2.txt");

            while (row != null)
            {

                row = streamreader.ReadLine();

                if (row != null)
                {
                    if (row.StartsWith("A"))
                    {
                        if (row.EndsWith("X"))
                        {
                            totalscore += 3;
                        }
                        if (row.EndsWith("Y"))
                        {
                            totalscore += 4;
                        }
                        if (row.EndsWith("Z"))
                        {
                            totalscore += 8;
                        }
                    }
                    if (row.StartsWith("B"))
                    {
                        if (row.EndsWith("X"))
                        {
                            totalscore += 1;
                        }
                        if (row.EndsWith("Y"))
                        {
                            totalscore += 5;
                        }
                        if (row.EndsWith("Z"))
                        {
                            totalscore += 9;
                        }
                    }
                    if (row.StartsWith("C"))
                    {
                        if (row.EndsWith("X"))
                        {
                            totalscore += 2;
                        }
                        if (row.EndsWith("Y"))
                        {
                            totalscore += 6;
                        }
                        if (row.EndsWith("Z"))
                        {
                            totalscore += 7;
                        }
                    }
                }

            }
            Console.WriteLine(totalscore);
            

        }



    }
}
