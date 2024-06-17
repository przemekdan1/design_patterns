using System;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Globalization;

namespace CurrencyExchanger
{
    class Program
    {
        public static string url = @"https://www.nbp.pl/kursy/xml/lasta.xml";
        public static void Main(string[] args)
        {
            UserInterface.getUserInput();
        }
    }
}
