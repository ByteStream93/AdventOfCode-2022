using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Days10
{
    public class Day10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First part of day 10:");

            part1();


        }

        //13320 & 13540 are too high... 12820 false too

        static int cycle = 0;
        static int tempResult = 1;
        static int result = 0;
        public static void part1()
        {
            var input = File.ReadAllLines("C:\\Users\\Marco\\Source\\Repos\\ByteStream93\\AdventOfCode-2022\\Days10\\Input10.txt");

            List<string> inputText = new List<string>(input);

            

            foreach (var line in inputText)
            {
                if (line.StartsWith("a"))
                {
                    var numToAdd = line.Split(" ");

                    for (int turn = 0; turn < 2; turn++)
                    {
                        cycle++;
                        check();
                    }                   
                                        
                    tempResult += Int32.Parse(numToAdd[1]);
                }
                if (line.StartsWith("n"))
                {
                    cycle++;
                    check();
                    
                }               
            }

            Console.WriteLine(result);

        }
        public static void check()
        {
            if ((cycle - 20) % 40 == 0 )
            {
              
                    Console.WriteLine(tempResult);
                    result += tempResult * cycle;
               
                
            }
        }
    }
}
