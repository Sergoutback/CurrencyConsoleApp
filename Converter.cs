using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConsoleApp
{
    public class Converter
    {        
        public decimal myAccountValue;
        public decimal exchangeRubValue = 1M;
        public decimal exchangeUsdValue;
        public decimal exchangeEurValue;
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
            var account = new Account();
            var calculator = new Calculator();
            

            Console.WriteLine($"How much money ({currencyRub}) do you have?");
            account.AccountValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"You have: {account.AccountValue} {currencyRub}");
            Console.WriteLine("Wich currency you neeed:");
            Console.WriteLine($"{currencyUsd}, {currencyEur}, {currencyGrn}?");

            

            calculator.Calculation();
            calculator.CurrencyNewMyAccountValue();
            Console.ReadLine();
        }
    }
}
