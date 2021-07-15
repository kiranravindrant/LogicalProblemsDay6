using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistinctCouponNumbers
{
    class DistinctRandom
    {
        public static void CouponNumbers()
        {


            int n, count = 0;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            int[] coupon = new int[n];
            for (int i = 0; i < coupon.Length; i++)
            {
                Random rand = new Random();
                coupon[i] = rand.Next(1, n + 1);
                Console.WriteLine("Added " + coupon[i] + " to array index " + i + " ");
                for (int j = 0; j < i; j++)
                {
                    if (coupon[i] == coupon[j])                     //if true then duplicates present
                    {
                        count++;
                        //Console.WriteLine("count "+count);//
                        break;
                    }

                }


            }
            int distinct = n - count;
            Console.WriteLine("Count of  Distinct Random Numbrs  " + distinct);




            Console.WriteLine("Array filtered out  with Duplicates " );
            
            int[] dist= coupon.Distinct().ToArray();
            Array.ForEach(dist, v => Console.Write(v+" ")); //will print each elements of the array 

            Console.ReadLine();
        }
    }
}
