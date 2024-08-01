using System;

namespace Practica_OCP
{
    public class TaxCalculator
    {
        private readonly Dictionary<string, ITaxCalculator> taxCalculators;

        public TaxCalculator()
        {
            taxCalculators = new Dictionary<string, ITaxCalculator>
        {
            { "India", new IndiaTaxCalculator() },
            { "USA", new USATaxCalculator() },
            { "UK", new UKTaxCalculator() }
        };
        }

        public decimal Calculate(decimal income, decimal deduction, string country)
        {
            if (taxCalculators.ContainsKey(country))
            {
                return taxCalculators[country].CalculateTax(income, deduction);
            }
            else
            {
                throw new Exception("Country not supported");
            }
        }
    }
}

