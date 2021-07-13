using System;

namespace PerfectNumbers
{
    class PerfectNumbers
    {
        static void Main(string[] args)
        {
            int number, sum = 0, n;
            Console.Write("enter the Number ");
            number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }

            
        }
    }  
}