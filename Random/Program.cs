using System;
using System.Collections.Generic;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var firstList = new List<int>();
            var firstListSquared = new List<int>();
            var firstListSquaredNoOdds = new List<int>();
            var length = 20;
            for (var i = 0; i < length; i++)
            {
                firstList.Add(rand.Next(1,51));
            }
            Console.WriteLine("List of 20 random numbers.");
            foreach (var number in firstList)
            {
                Console.WriteLine(number);
                firstListSquared.Add(number * number);
            }
            Console.WriteLine("List of previous numbers squared.");
            foreach (var item in firstListSquared)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine(item);
                    firstListSquaredNoOdds.Add(item);
                }
            }
            Console.WriteLine("List of only the even squared numbers");
            foreach (var item in firstListSquaredNoOdds)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
