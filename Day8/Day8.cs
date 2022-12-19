using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Day8
    {

        public static void Main(string[] args)
        {
            part1();
            
        }


        static void part1()
        {
            var inputText = File.ReadAllLines("C:\\Users\\herzo\\Source\\Repos\\ByteStream93\\AdventOfCode-2022\\Day8\\Input8.txt");

            var input = new List<string>(inputText);
            var field = new List<List<int>>();

            foreach (var line in input)
            {
                var row = new List<int>();

                foreach (var tree in line)
                {
                    row.Add(Convert.ToInt32(tree));
                }
                field.Add(row);
            }

            int visibleTrees = 0;

            visibleTrees += (field.Count * 2) + (field[0].Count * 2) - 4;





            for (int horizontal = 1; horizontal < field.Count - 1; horizontal++)
            {
                for (int vertikal = 1; vertikal < field[horizontal].Count - 1; vertikal++)
                {

                    int heightCurrentTree = field[horizontal][vertikal];

                    bool visibility = true;


                    for (int columnLeft = vertikal - 1; columnLeft >= 0; columnLeft--)
                    {
                        if (field[horizontal][columnLeft] >= heightCurrentTree)
                        {

                            visibility = false;
                            break;
                        }
                    }
                    if (visibility)
                    {
                        visibleTrees++;
                        continue;
                    }

                    visibility = true;

                    for (int columnRight = vertikal + 1; columnRight < field[horizontal].Count; columnRight++)
                    {
                        if (field[horizontal][columnRight] >= heightCurrentTree)
                        {
                            visibility = false;
                            break;
                        }
                    }
                    if (visibility)
                    {
                        visibleTrees++;
                        continue;
                    }

                    visibility = true;

                    for (int upperRow = horizontal - 1; upperRow >= 0; upperRow--)
                    {
                        if (field[upperRow][vertikal] >= heightCurrentTree)
                        {
                            visibility = false;
                            break;
                        }
                    }
                        if (visibility)
                        {
                            visibleTrees++;
                            continue;
                        }

                        visibility = true;

                    for (int belowRow = horizontal + 1; belowRow < field.Count; belowRow++)
                    {
                        if (field[belowRow][vertikal] >= heightCurrentTree)
                        {
                            visibility = false;
                            break;
                        }
                    }
                            if (visibility)
                            {
                                visibleTrees++;
                                continue;
                            }

                            visibility = true;

                 }
             }

            Console.WriteLine(visibleTrees);
        }

     }
            
}
      
        



