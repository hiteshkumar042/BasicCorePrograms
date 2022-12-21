namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs!");
            Console.WriteLine("\n1. Flip Coin and percentage of Heads and Tails.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoinPercentage flipCoin = new FlipCoinPercentage();
                    flipCoin.FlipCoinPercentageFn();
                break;

                default:
                    Console.WriteLine("Choose from given options only!");
                break;
            }

        }
    }
}