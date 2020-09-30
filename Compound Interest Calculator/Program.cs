/*
 * C# Program to Calculate Compound Interest
 */
using System;
namespace compund
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount;
            double interest;
            int years;
            double balance = 0;

            Console.WriteLine("Enter the Amount");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Interest Rate");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Enter number of Years");
            years = Convert.ToInt32(Console.ReadLine());

            for (int i = years; i >= 0; i--)
            {
                balance = amount * Math.Pow((1 + interest), years);


            }

            {
                Console.WriteLine("Total Amount Balance is: ${0}", balance);
            }
            Console.ReadLine();
        }
    }
}