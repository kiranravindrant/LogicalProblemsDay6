using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int reverse = 0;
            Console.WriteLine("Enter the Number:  ");
            Num = int.Parse(Console.ReadLine());



            

            while (Num > 0)
            {
                int digit = (Num % 10);
                reverse = reverse * 10 + digit;
                Num = (Num / 10);


            }
            Console.WriteLine(+reverse + ":is the reverse of the number");
            Console.ReadLine();


        }
    }
}
