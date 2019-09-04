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
                if(i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.WriteLine("FizzBang");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if(i % 5 == 0)
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine("BuzzBang");
                    }
                    else
                    {
                        Console.WriteLine("Buzz");
                    }
                }
                else if(i % 7 == 0)
                {
                    Console.WriteLine("Bang");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
