using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args) 
        { 
            for (int i = 1; i < 101; i++)
            {
                //Consle.WriteLine(i);
                if((i % 3 == 0) && (i % 5 == 1))
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                }

            }
        }
    }
}