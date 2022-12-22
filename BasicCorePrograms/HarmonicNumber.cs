using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void HarmonicNumberFn()
        {
            double sum =0;
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                Console.Write("1/{0} + ", i);
                sum = sum + 1 / (float)i;
            }
            Console.WriteLine("\nHarmonic value of {0} term is : {1}",num,sum);
         
        }
    }
}
