using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    class UserInterface
    {
        private CurrencyConverterSingleton currencyConverter;

        public UserInterface(CurrencyConverterSingleton currencyConverter)
        {
            this.currencyConverter = currencyConverter;
        }

        public static void getUserInput()
        {
            XMLDataProvider dataHandler = new XMLDataProvider();
            dataHandler.loadDataFromXml(Program.url);
            dataHandler.loadCurrencies();

            foreach (var currency in dataHandler.currencies)
            {
                Console.WriteLine($"Currency code: {currency.Key}, Name: {currency.Value.CurrencyName}, Rate: {currency.Value.CurrencyRate}");
            }

            Console.WriteLine();

            Currency inputCurrency;
            Currency outputCurrency;

            string inputCurrencyCode = "";
            string outputCurrencyCode = "";
            double amountInput = 0;

            bool areCurrenciesValid = false;
            while(!areCurrenciesValid)
            {
                Console.Write("Enter currency: ");
                inputCurrencyCode = Console.ReadLine();

                Console.Write("Enter target currency: ");
                outputCurrencyCode = Console.ReadLine();

                if ((dataHandler.currencies.ContainsKey(inputCurrencyCode)) && (dataHandler.currencies.ContainsKey(outputCurrencyCode)))
                {
                    areCurrenciesValid = true;
                }
                else
                {
                    Console.WriteLine("Incorrect currency code. Enter it once again.");
                }
            }

            Console.WriteLine();

            bool correctAmount = false;
            while(!correctAmount)
            {
                Console.Write("Enter available funds: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out amountInput) && amountInput >= 0)
                {
                    correctAmount = true;
                }
                else
                {
                    Console.WriteLine("Incorrect value. Enter it once again.");
                }
            }

            Console.WriteLine();

            inputCurrency = dataHandler.currencies[inputCurrencyCode];
            outputCurrency= dataHandler.currencies[outputCurrencyCode];

            CurrencyConverterSingleton currencyConverter = CurrencyConverterSingleton.getInstance();
            currencyConverter.inputCurrency = inputCurrency;
            currencyConverter.outputCurrency = outputCurrency; 
            currencyConverter.value = amountInput;

            Console.WriteLine($"\n\n{amountInput} {inputCurrencyCode} = {Math.Round(currencyConverter.convert(),2)} {outputCurrencyCode}\n{inputCurrency.CurrencyName} -> {outputCurrency.CurrencyName}\n\n\n");
            

        }
    }
}
