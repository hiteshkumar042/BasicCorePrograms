using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactors
    {
        public static void PrimeFactorsFn()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
<<<<<<< HEAD
            for (int i = 2; i <= num/2; i++)
=======
            for (int i = 2; i <= num; i++)
>>>>>>> 7abd385085940a84427b0c5a86044559a91ee135
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }   
            }
            if (num != 1)
            {
               Console.WriteLine(num);
            }
        }
    }
}
