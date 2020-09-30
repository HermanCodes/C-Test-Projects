using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //writing and gathering the initial information
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Please enter an amount in cents to convert to coins:");
            string totalAsString = Console.ReadLine();
            double total = Math.Floor(Convert.ToDouble(totalAsString));
            Console.WriteLine($"{total} cents is equal to...");

            //defining coin values
            int quaterValue = 25;
            int dimeValue = 10;
            int nickleValue = 5;

            //calculate the change
            double quaterCoins = Math.Floor(total / quaterValue);
            double remainder = total % quaterValue;

            double dimeCoins = Math.Floor(remainder / dimeValue);
            remainder %= dimeValue;
            /*Console.WriteLine(silverCoins);
            Console.WriteLine(remainder);*/

            double nickleCoins = Math.Floor(remainder / nickleValue);
            remainder %= nickleValue;

            //print results of all coins
            Console.WriteLine($"Quater coins: {quaterCoins}");
            Console.WriteLine($"Dime coins: {dimeCoins}");
            Console.WriteLine($"Nickle coins: {nickleCoins}");
            Console.WriteLine($"Penny coins: {remainder}");
        }
    }
}
