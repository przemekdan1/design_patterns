using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    class XMLDataLoader
    {
        private string url;
        private CurrencyConverterSingleton currencyConverter;
        public XMLDataLoader(string url,CurrencyConverterSingleton currencyConverter)
        {
            this.url = url;
            this.currencyConverter = currencyConverter;
        }
    }
}
