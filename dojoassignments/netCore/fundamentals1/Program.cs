﻿using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                // Console.WriteLine(i);
            }

            for (int j = 1; j <= 100; j++)
            {
                if (((j % 3 == 0) || (j % 5 == 0)) && (j % 15 != 0))
                {
                    // Console.WriteLine(j);
                }
            }
            for (int h = 1; h <= 100; h++)
            {
                if (h % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (h % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (h % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            // Console.WriteLine("Hello World!");
        }
    }
}
