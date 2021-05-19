using System;

namespace ForEachCalcAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var count = 0;
            var highest = 0;
            var lowest = 1000;
            //declaring variable nbrs as an int in a [collection of values] = {value1, value2...}
            int[] nbrs =
            {
               754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
               187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
               460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
               690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
               435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };
            //For loop, saying for each (newVariable named nbr, setting nbr = each value in nbrs collection)
            foreach(var nbr in nbrs)
            {//if the current nbr > variable highest
                if(nbr > highest)
                {//set highest = that nbr
                    highest = nbr;
                }//if the current nbr < variable lowest
                if(nbr < lowest)
                {//set lowest = that nbr
                    lowest = nbr;
                }//Set variable sum = current sum + nbr
                sum = sum + nbr;
                //add 1 to count
                count++;
                 //at the end, goes to the next value in nbrs and sets nbr = that value
            }
            var avg = sum / count;
            Console.WriteLine($"There are {count} numbers. The average is {avg}");
            Console.WriteLine($"Highest is {highest}, lowest is {lowest}");
        }
    }
}
