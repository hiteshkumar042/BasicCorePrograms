using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargeAmongThreeNum
    {
        public static void LargeAmongThreeNumFn()
        {

            Console.WriteLine("Enter Number 1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 :");
            int number3 = Convert.ToInt32(Console.ReadLine());
            //Comparing
            if ((number1 == number2) && (number2 == number3))
                Console.WriteLine("All inputs are equal");
            if (number1 > number2 && number1 > number3)
                Console.WriteLine(" Number {0} is greatest",number1);
            if (number2 > number1 && number2 > number3)
                Console.WriteLine("Number {0} is greatest",number2);
            if (number3 > number1 && number3 > number2)
                Console.WriteLine("Number {0} is greatest",number3);
        }
    }
}
