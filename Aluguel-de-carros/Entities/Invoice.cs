using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aluguel_de_carros.Entities
{
    class Invoice
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice()
        {
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: " + BasicPayment.ToString("F2", CI) + 
                "\nTax: " + Tax.ToString("F2", CI) + 
                "\nTotal payment: " + TotalPayment.ToString("F2", CI);
            
        }
    }
}
