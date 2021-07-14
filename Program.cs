using System;

namespace IsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int factors = 0;
            Console.WriteLine("PROGRAM TO CHECK PRIME NUMBER OR NOT");
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n / 2; i++)
            {


                if ((n % i) == 0) 
                {
                    factors++;
                    

                }
            }

            if (factors <= 2)
            {
                Console.WriteLine(n + "is a Prime Number");
            }
            else
                Console.WriteLine(n + "is NOT a Prime Number");

            Console.ReadLine();


        }
    }
}
