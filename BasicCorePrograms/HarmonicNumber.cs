using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void HarmonicNumberFn()
        {
            double result =0;
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                Console.Write("1/{0} + ", i);
                result += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", num, result);
        }
    }
}
