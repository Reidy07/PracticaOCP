using System;


namespace Practica_OCP
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal income, decimal deduction);
    }
    public class IndiaTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;
                        decimal taxAmount = 0;
            if (taxableIncome <= 500000)
                taxAmount = taxableIncome * 0.05m;
            else if (taxableIncome <= 1000000)
                taxAmount = taxableIncome * 0.2m;
            else
                taxAmount = taxableIncome * 0.3m;

            return taxAmount;
        }
    }

    public class USATaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;
         
            decimal taxAmount = 0;
            if (taxableIncome <= 9875)
                taxAmount = taxableIncome * 0.1m;
            else if (taxableIncome <= 40125)
                taxAmount = taxableIncome * 0.12m;
            else if (taxableIncome <= 85525)
                taxAmount = taxableIncome * 0.22m;
            else
                taxAmount = taxableIncome * 0.24m;

            return taxAmount;
        }
    }

    public class UKTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;

            decimal taxAmount = 0;

            if (taxableIncome <= 12500)
                taxAmount = 0;
            else if (taxableIncome <= 50000)
                taxAmount = (taxableIncome - 12500) * 0.2m;
            else if (taxableIncome <= 150000)
                taxAmount = (37500 * 0.2m) + ((taxableIncome - 50000) * 0.4m);
            else
                taxAmount = (37500 * 0.2m) + (100000 * 0.4m) + ((taxableIncome - 150000) * 0.45m);

            return taxAmount;
        }
    }

}
