using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConsoleApp
{
    class Program
    {
        decimal myAccountValue = 1000;
        decimal exchangeRubValue = 1;
        decimal exchangeUsdValue = 75;
        decimal exchangeEurValue = 85;
        decimal exchangeGrnValue = 0.3M;
        string currencyRub = "RUB";
        string currencyUsd = "USD";
        string currencyEur = "EUR";
        string currencyGrn = "GRN";
        public string currencyChoice;
        public decimal currencyForExchange;


        static void Main(string[] args)
        {
            var anInstanceofMyClass = new Program();
            anInstanceofMyClass.StartApp();
            
        }

        public void StartApp()
        {
            Console.Write("You have: ");
            Console.Write(myAccountValue + " ");
            Console.WriteLine(currencyRub);
            Console.WriteLine("Wich currency you neeed:");
            Console.WriteLine($"{currencyRub}, {currencyUsd}, {currencyEur}, {currencyGrn}?");

            CurrencyChoice();            
            Exchange();            
            Console.WriteLine($"1 RUB = {currencyForExchange} {currencyChoice}");            
            Console.ReadLine();
        }

        public string CurrencyChoice()
        {
            currencyChoice = Console.ReadLine();

            if (currencyChoice == "RUB" || currencyChoice == "USD" || currencyChoice == "EUR" || currencyChoice == "GRN")
            {
                return currencyChoice;                               
            }

            else
            {
                Console.WriteLine("Exception 001! You write wrong value. Please, make your choice between RUB, USD, EUR, GRN");
                return currencyChoice = Console.ReadLine();
            }
        }


        public decimal Exchange()
        {
            if (currencyChoice == "RUB")
                return currencyForExchange = exchangeRubValue;

            else if (currencyChoice == "USD")
                return currencyForExchange = exchangeUsdValue;

            else if (currencyChoice == "EUR")
                return currencyForExchange = exchangeEurValue;

            else if (currencyChoice == "GRN")
                return currencyForExchange = exchangeGrnValue;
            else
                Console.WriteLine("Exception 002! You wrote the wrong value twice! Goodbye!");
                return currencyForExchange = 0;
        }


        //public decimal Calculator()
        //{

        //}
    }
}
