using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConsoleApp
{
    public class Calculator: Converter
    {
        public decimal newMyAccountValue;

        public decimal currencyValueForChange;
        public decimal totalNewMyAccountValue;
        public decimal currencyNewMyAccountValue;

                
        public void Calculation()
        {
            var currencyParse = new CurrencyParse();
            currencyParse.ParceUsdEur();
            currencyParse.ParceUsdgrn();
            Console.WriteLine($"USD: {currencyParse.usd} EUR: {currencyParse.euro} GRN: {currencyParse.grnRub}");
            exchangeUsdValue = currencyParse.usd;
            exchangeEurValue = currencyParse.euro;
            exchangeGrnValue = currencyParse.grnRub;

            CurrencyChoice();


            Console.WriteLine($"1 RUB = {currencyForExchange} {currencyChoice}");
            Console.WriteLine("Need to change something? Y/N");

            yesNoChoice = Console.ReadLine();

            if (yesNoChoice == "Y")
            {
                Console.WriteLine($"How many {currencyChoice} you neeed?");                
                currencyValueForChange = Convert.ToDecimal(Console.ReadLine());                
            }
            else
            {
                Console.WriteLine($"Goodbye");
            }
        }


        public void CurrencyChoice()
        {
            currencyChoice = Console.ReadLine();

            if (currencyChoice == "RUB")
                currencyForExchange = exchangeRubValue;

            else if (currencyChoice == "USD")
                currencyForExchange = exchangeUsdValue;

            else if (currencyChoice == "EUR")
                currencyForExchange = exchangeEurValue;

            else if (currencyChoice == "GRN")
                currencyForExchange = exchangeGrnValue;
            else
                Console.WriteLine("Exception 001! You wrote the wrong value! Goodbye!");
                
        } 


        public void CurrencyNewMyAccountValue()
        {           
            ChangeCurrency();            
            Console.Write($"You have: {newMyAccountValue} RUB and {currencyValueForChange} {currencyChoice}");
                             
        }


        public decimal ChangeCurrency()
        {
            myAccountValue = Account.accountValue;            

            if (currencyChoice == "USD")
            {
                return newMyAccountValue = myAccountValue - currencyValueForChange * exchangeUsdValue;
            }

            else if (currencyChoice == "EUR")
            {
                return newMyAccountValue = myAccountValue - currencyValueForChange * exchangeEurValue;
            }

            else if (currencyChoice == "GRN")
            {
                return newMyAccountValue = myAccountValue - currencyValueForChange * exchangeGrnValue;
            }

            else
                return myAccountValue;
        }
    }
}
