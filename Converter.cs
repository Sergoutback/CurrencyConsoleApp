using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConsoleApp
{
    public class Converter
    {
        public decimal myAccountValue = 1000M;
        public decimal exchangeRubValue = 1M;
        public decimal exchangeUsdValue = 75M;
        public decimal exchangeEurValue = 85M;
        public decimal exchangeGrnValue = 0.3M;
        public string currencyRub = "RUB";
        public string currencyUsd = "USD";
        public string currencyEur = "EUR";
        public string currencyGrn = "GRN";
        public string currencyChoice;
        public decimal currencyForExchange;
        public string yesNoChoice;


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
            Console.WriteLine("Need to change something? Y/N");
            var calculator = new Calculator();
            calculator.Calculation();
            calculator.ChangeCurrency();
            calculator.CurrencyNewMyAccountValue();
            Console.ReadLine();
        }


        public string CurrencyChoice()
        {
            currencyChoice = Console.ReadLine();

            if (currencyChoice == "RUB" || currencyChoice == "USD" || currencyChoice == "EUR" || currencyChoice == "GRN")
            {
                return currencyChoice;
            }
           
            Console.WriteLine("Exception 001! You write wrong value. Please, make your choice between RUB, USD, EUR, GRN");
            return currencyChoice = Console.ReadLine();
            
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
    }
}
