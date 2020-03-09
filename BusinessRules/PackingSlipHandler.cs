using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing.Model;

namespace OrderProcessing.BusinessRules
{
    class PackingSlipHandler : BasePaymentProcessing
    {
        protected override bool CanProcess(Payment payment)
        {
            return payment.ProductType == "Physical";
        }

        protected override void Process(Payment payment)
        {
            Console.WriteLine("Generate packing slip for order: {0}", payment.Reference);
        }
    }
}
