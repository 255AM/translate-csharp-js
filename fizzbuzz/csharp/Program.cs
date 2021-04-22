using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //iterate through 100 numbers
            // if number is divisible by 15 say fizzbuzz
            // if number is divisible by 3 say fizz
            // if 5 say buzz
            // else write number
            for (int i = 0; i < 101; i++) 
            {
            if (i % 15 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            } 
            else
            {   
                Console.WriteLine(i);
            }
            
            }
        }
    }
}
