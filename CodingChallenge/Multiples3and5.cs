using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    class Multiples3and5
    {
        static void Main(string[] args)
        {
            // LAB:
            // Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.

            //Finds all multiples of 3 below 1000 and adds them to the List "multiplesof3".
            int sumof3 = 0;            
            List<int> multiplesof3 = new List<int>();

            Console.WriteLine("What is the sum of every multiple of 3 below 1000?\n");    

            for (int i = 0; i <= 1000; i += 3)
            {
                sumof3 += i;
                multiplesof3.Add(i);
            }
            Console.WriteLine($"The sum of every multiple of 3 below 1000 is equal to {sumof3}.\n");

            //Prints all multiples of 3 below 1000 in a block.
            for (int i = 0; i < multiplesof3.Count; i++)
            { Console.Write($"{multiplesof3[i]}|"); }
            
            //Finds all multiples of 3 below 1000 and adds them to the List "multiplesof3".
            int sumof5 = 0;
            List<int> multiplesof5 = new List<int>();

            Console.WriteLine("\n\nWhat is the sum of every multiple of 3 below 1000?\n");

            for (int i = 0; i <= 1000; i += 5)
            {
                sumof5 += i;
                multiplesof5.Add(i);
            }

            Console.WriteLine($"The sum of every multiple of 5 below 1000 is equal to {sumof5}.\n");

            //Prints all multiples of 5 below 1000 in a block.
            for (int i = 0; i < multiplesof5.Count; i++)
            { Console.Write($"{multiplesof5[i]}|"); }

            Console.WriteLine("\n");

        }
    }
}
