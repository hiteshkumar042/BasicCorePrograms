namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs!");
            Console.WriteLine("\n1. Flip Coin Percentages.\n2. Leap Year.\n3. Power Of Two.\n4. Harmonic Number.\n5. Prime Factors.");
            Console.WriteLine("6. Quotient & Remainder.\n7. Swap Two Number.\n8. Even or Odd.\n9. Vowel Or Consonant.\n10. Largest Among Three Number.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Q1. Flip Coin and percentage of Heads and Tails.
                    FlipCoinPercentage.FlipCoinPercentageFn();
                    break;
                case 2:
                    //Q2 . Leap Year
                    LeapYear.LeapYearFn();
                    break;
                case 3:
                    //Q3. Power of 2
                    PowerOfTwo.PowerOfTwoFn();
                    break;
                case 4:
                    //Q4. Harmonic Number
                    HarmonicNumber.HarmonicNumberFn();
                    break;
                case 5:
                    //Q5. Prime Factors
                    PrimeFactors.PrimeFactorsFn();
                    break;
                case 6:
                    //Q6. Compute Quotient and Remainder
                    QuotientRemainder.QuotientRemainderFn();
                    break;
                case 7:
                    //Q7. Swap Two Number
                    SwapTwoNumber.SwapTwoNumberFn();
                    break;
                case 8:
                    //Q8. Even or Odd Number
                    EvenOrOdd.EvenOrOddFn();
                    break;
                case 9:
                    //Q9.Vowel Or Consonant 
                    VowelOrConsonant.VowelOrConsonantFn();
                    break;
                case 10:
                    //Q10.Largest Among Three Number 
                    LargeAmongThreeNum.LargeAmongThreeNumFn();
                    break;
                default:
                    Console.WriteLine("Choose from given options only!");
                break;
            }

        }
    }
}