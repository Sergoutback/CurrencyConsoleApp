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


        public decimal Calculation()
        {
            yesNoChoice = Console.ReadLine();

            if (yesNoChoice == "Y")
            {
                Console.WriteLine($"How many {currencyChoice} you neeed?");                
                currencyValueForChange = Convert.ToDecimal(Console.ReadLine());
                return currencyValueForChange;
            }
            else
            {
                Console.WriteLine($"Goodbye");
                return 0M;
            }
        }


        public decimal ChangeCurrency()
        {
            currencyChoice = CurrencyChoice();

            if (currencyChoice == "RUB")
            {
                return newMyAccountValue = myAccountValue - currencyValueForChange * exchangeRubValue;
            }


            else if (currencyChoice == "USD")
            {
                return newMyAccountValue = myAccountValue - currencyValueForChange * exchangeUsdValue;
            }

            else if (currencyChoice == "EUR")
            {
                return newMyAccountValue = myAccountValue - currencyValueForChange * exchangeEurValue;
            }

            else 
            {
                return newMyAccountValue = myAccountValue - currencyValueForChange * exchangeGrnValue;
            }
            
        }


        public decimal CurrencyNewMyAccountValue()
        {
            Console.Write($"You have: {newMyAccountValue} RUB and {currencyValueForChange} {currencyChoice}");


            return totalNewMyAccountValue;
        }
    }
}
