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
        public decimal grnRub;
        public decimal grnUsd = 27.21M;

        ///using System.Xml.Linq;
        public void ParceUsdEur()
        {
            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var element = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = element.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            string eur = element.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
            // Console.WriteLine($"USD: {dollar} EUR: {eur}");
            usd = Decimal.Parse(dollar.Replace(',', '.'));
            euro = Decimal.Parse(eur.Replace(',', '.'));
        }


        public void ParceUsdgrn()
        {
            grnRub = usd / grnUsd;
        }
    }
}
