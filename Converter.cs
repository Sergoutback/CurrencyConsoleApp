using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConsoleApp
{
    public class Converter
    {
        public decimal myAccountValue = 1000000M;
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
            Console.WriteLine($"You have: {myAccountValue} {currencyRub}");
            Console.WriteLine("Wich currency you neeed:");
            Console.WriteLine($"{currencyUsd}, {currencyEur}, {currencyGrn}?");

            
            var calculator = new Calculator();
            calculator.Calculation();            
            calculator.CurrencyNewMyAccountValue();
            Console.ReadLine();
        }
    }
}
