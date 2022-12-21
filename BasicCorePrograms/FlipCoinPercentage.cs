using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoinPercentage
    {
        public void FlipCoinPercentageFn()
        {
            int tailCount = 0, headCount = 0;
            Random random = new Random();
            Console.WriteLine("\nEnter a number of times to flip a coin : ");
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i <= numberOfTimes; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("Tail Count : {0} & Head Count : {1}", tailCount,headCount);
            double tailPercentage = (tailCount *100) / numberOfTimes;
            double headPercentage = (headCount *100) / numberOfTimes;
            Console.WriteLine("Tail Count Percentage is : {0}% & Head Count Percentage is : {1}%", tailPercentage, headPercentage);
        }
    }
}
