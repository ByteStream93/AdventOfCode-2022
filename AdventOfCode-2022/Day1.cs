using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022
{
    internal class Day1
    {
        static int elve = 0;
        static int heaviestElve;
        static int result;
        static int highestScore;
        static String row = "";
        static List<int> list = new List<int>();





        static StreamReader streamReader = new StreamReader("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode\\Day1\\Day1\\Input.txt");
        static StreamReader streamReader2 = new StreamReader("C:\\Users\\herzo\\source\\repos\\ByteStream93\\AdventOfCode\\Day1\\Day1\\Input.txt");
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1 of 1st Day: ");
            part1();

            Console.WriteLine();

            Console.WriteLine("Part 2 of 1st Day: ");
            part2();
        }

        public static void part1()
        {
            while (row != null)
            {
                row = streamReader.ReadLine();

                if (row == "")
                {
                    if (result > highestScore)
                    {
                        highestScore = result;
                        heaviestElve = elve;


                    }

                    elve++;
                    result = 0;

                }
                else
                {
                    result += Convert.ToInt32(row);
                }
            }
            Console.WriteLine("The elve with the most cal on the " + heaviestElve + " Place carries " + highestScore + " calories");
        }


        public static void part2()
        {
            String rowPart2 = "";
            int[] caloriesCarried = new int[3];
            int result2 = 0;

            while (rowPart2 != null)
            {
                rowPart2 = streamReader2.ReadLine();

                if (rowPart2 == "")
                {

                    for (int i = 2; i >= 0; i--)
                    {
                        if (result2 > caloriesCarried[i])
                        {
                            if (i != 2)
                            {
                                caloriesCarried[i + 1] = caloriesCarried[i];
                            }
                            caloriesCarried[i] = result2;

                        }
                    }
                    result2 = 0;
                }
                else
                {
                    result2 += Convert.ToInt32(rowPart2);
                }


            }
            int totalCalories = 0;

            foreach (int num in caloriesCarried)
            {
                totalCalories += num;
            }
            Console.WriteLine("The total of the calories carried by the first three elves is: " + totalCalories);
        }


    }
}

    

