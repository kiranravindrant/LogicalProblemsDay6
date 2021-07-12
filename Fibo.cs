using System;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 0, value2 = 1, value3, i, n;


            Console.WriteLine("PROGRAM TO PRINT FIRST N FIBONACCI SERIES ");

            Console.WriteLine("Enter value of N ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(value1);
            Console.Write(" "+value2);

            for (i = 2; i < n; i++)
            {
                value3 = value1 + value2;
                Console.Write(" "+value3);
                value1 = value2;
                value2 = value3;


            }
        }

    }
}


