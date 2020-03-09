using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing.Model;

namespace OrderProcessing.BusinessRules
{
    class CommissionPaymentHandler : BasePaymentProcessing
    {
        protected override bool CanProcess(Payment payment)
        {
            return (payment.ProductType == "Book" || payment.ProductType == "Physical") ? true : false;
        }

        protected override void Process(Payment payment)
        {
            Console.WriteLine("Generate Commission for order: {0}", payment.Reference);
        }
    }
}
