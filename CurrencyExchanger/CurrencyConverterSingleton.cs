using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    class CurrencyConverterSingleton
    {
        public Currency inputCurrency { get; set; }
        public Currency outputCurrency { get; set; }
        public double value { get; set; }

        public CurrencyConverterSingleton()
        { }
        public CurrencyConverterSingleton(Currency inputCurrency, Currency outputCurrency, double value)
        {
            this.inputCurrency = inputCurrency;
            this.outputCurrency = outputCurrency;
            this.value = value;
        }

        private static CurrencyConverterSingleton? _instance;

        public static CurrencyConverterSingleton getInstance()
        {
            if(_instance == null) _instance= new CurrencyConverterSingleton();
            return _instance;
        }



        public double convert()
        {
            if(inputCurrency == null && outputCurrency == null) 
            {
                throw new ArgumentException("Input and output currencies should be set");
            }
            double inputRate = inputCurrency.CurrencyRate / inputCurrency.CurrencyConverter;
            double outputRate = outputCurrency.CurrencyRate / outputCurrency.CurrencyConverter;
            return  value * inputRate / outputRate;
        }

        
    }
}
