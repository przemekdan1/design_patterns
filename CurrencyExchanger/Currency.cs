using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    class Currency : ICurrency
    {
        private string currencyName;
        private int currencyConverter;
        private string currencyCode;
        private float currencyRate;

        public float CurrencyRate
        {
            get { return currencyRate; }
            set { currencyRate = value; }
        }

        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }

        public int CurrencyConverter
        {
            get { return currencyConverter; }
            set { currencyConverter = value; }
        }

        public string CurrencyName
        {
            get { return currencyName; }
            set { currencyName = value; }
        }

        public string GetName()
        {
            return currencyName;
        }

        public string GetCurrencyCode()
        {
            return currencyCode;
        }

        public string GetCurrencyName()
        {
            return currencyName;
        }

        public string GetCurrencySymbol()
        {
            return ""; 
        }

        public string getName()
        {
            throw new NotImplementedException();
        }

        public string getCurrencyCode()
        {
            throw new NotImplementedException();
        }

        public string getCurrencyName()
        {
            throw new NotImplementedException();
        }

        public string getCurrencySymbol()
        {
            throw new NotImplementedException();
        }

        public Currency(string name, int converter, string code, float rate)
        {
            this.currencyName = name;
            this.currencyConverter = converter;
            this.currencyCode = code;
            this.currencyRate = rate;
        }
    }
}
