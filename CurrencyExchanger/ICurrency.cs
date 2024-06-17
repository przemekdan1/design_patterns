using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    interface ICurrency
    {
        public string getName();
        public string getCurrencyCode();
        public string getCurrencyName();
        public string getCurrencySymbol();
    }
}
