using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public static void PowerOfTwoFn()
        {
            Console.WriteLine("Enter a Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num&&num<=31;i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine("{0}'s Power {1} : {2}",2,i,result);
            }
        }
    }
}
