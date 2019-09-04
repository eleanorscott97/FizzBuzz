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
                string numberSubstitute = "";
                if (i % 3 == 0)
                {
                    numberSubstitute += "Fizz";
                }
                if (i % 5 == 0)
                {
                    numberSubstitute += "Buzz";
                }
                if (i % 7 == 0)
                {
                    numberSubstitute += "Bang";
                }

                if (string.IsNullOrEmpty(numberSubstitute))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(numberSubstitute);
                }
            }
        }
    }
}
