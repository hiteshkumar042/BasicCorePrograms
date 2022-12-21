using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactors
    {
        public void PrimeFactorsFn()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
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
