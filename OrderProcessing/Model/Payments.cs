using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Model
{
    public class Payment
    {
        public decimal Amount;
        public string ProductType;
        public int Reference;

        //Constructor
        public Payment (decimal amount, string productType, int reference)
        {
            this.Amount = amount;
            this.ProductType = productType;
            this.Reference = reference;
        }
    }

    public enum ProductType
    {
        Physical,
        Book,
        NonPhysical
    }
}
