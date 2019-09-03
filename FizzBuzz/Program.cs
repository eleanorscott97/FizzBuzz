using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 is the very special number given in the exercise
            int total = 100;

            for (int i = 1; i <= total; i++) 
            {
                // check for multiples of 3,5 and 3&5 - switch to Fizz, Buzz, FizzBuzz respectively
                if(i % 3 == 0)
                {
                    if(i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
