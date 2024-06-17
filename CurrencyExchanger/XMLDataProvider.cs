using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CurrencyExchanger
{
    class XMLDataProvider
    {
        public Dictionary<string, Currency> currencies = new Dictionary<string, Currency>();
        public string xmlContent;
        public XMLDataProvider() { }


        public void loadDataFromXml(string url)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


            using var httpClient = new HttpClient();
            var response = httpClient.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                xmlContent = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                throw new HttpRequestException($"Error downloading XML data from {url}: {response.ReasonPhrase}");
            }
        }



        public void loadCurrencies()
        {
            XDocument doc = XDocument.Parse(xmlContent);

            var currencyElements = doc.Descendants("pozycja");

            foreach (var currencyElement in currencyElements)
            {
                string currencyName = currencyElement.Element("nazwa_waluty")?.Value;
                int currencyConverter = int.Parse(currencyElement.Element("przelicznik")?.Value);
                string currencyCode = currencyElement.Element("kod_waluty")?.Value;
                float currencyRate = float.Parse(currencyElement.Element("kurs_sredni")?.Value.Replace(",", "."), CultureInfo.InvariantCulture);

                Currency currency = new Currency(currencyName, currencyConverter, currencyCode, currencyRate);
                currencies[currencyCode] = currency;
            }
            Currency polishCurrency = new Currency("polski zloty", 1, "PLN", 1);
            currencies.Add("PLN", polishCurrency);
        }
            
        
    }
}
