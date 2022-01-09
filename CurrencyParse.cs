using System;
using System.Linq;
using System.Net;
using System.Windows;
using System.Xml.Linq;

namespace CurrencyConsoleApp
{
    public class CurrencyParse
    {
        public decimal usd;
        public decimal euro;

        ///using System.Xml.Linq;
        public void ParceUsdEur()
        {
            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            string eur = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
            Console.WriteLine($"Евро: {eur} Доллар: {dollar}");
            usd = Convert.ToDecimal(dollar);
            euro = Convert.ToDecimal(eur);
        }
    }
}
