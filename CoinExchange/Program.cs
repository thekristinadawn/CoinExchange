
using System;

namespace CoinExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quarter = 0, dime = 0, nickel = 0, penny = 0;
            double currencyAmount;
            //double currencyAmount1;

            Console.WriteLine("Please enter current amount in dollars and cents.");
            currencyAmount = double.Parse(Console.ReadLine());
            do
            //find # of quarters
            {
                if (currencyAmount > .25)
                {
                    currencyAmount = (currencyAmount - .25);
                    quarter++;
                }
                //find # of dimes
                else if (currencyAmount <= .24 && currencyAmount > .09)
                {
                    currencyAmount = (currencyAmount - .10);
                    dime++;
                }
                //find # of nickels

                else if (currencyAmount <= .09 && currencyAmount > .05)
                {
                    currencyAmount = (currencyAmount - .05);
                    nickel++;
                }
                //find # of pennies

                else if (currencyAmount <= .04)
                {
                    currencyAmount = (currencyAmount - .01);
                    penny++;
                }
                

            } while (currencyAmount >= 0);
            Console.WriteLine("{0} quarters, {1} dimes, {2} nickels, {3} pennies", quarter, dime, nickel, penny);

        }
    }
}
