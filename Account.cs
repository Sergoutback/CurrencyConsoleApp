using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConsoleApp
{
    public class Account
    {
        public static decimal accountValue { get; private set; }

        public decimal AccountValue
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Exception 003! You cannot have a negative value on your account.");
                else
                    accountValue = value;
            }
            get { return accountValue; }
        }
    }
}
