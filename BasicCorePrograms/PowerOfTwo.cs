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
        public void PowerOfTwoFn()
        {
            int result = 0;
            Console.WriteLine("Enter a Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                result = 2 * i;
                Console.WriteLine("{0}*{1} : {2}",2,i,result);
            }
        }
    }
}
