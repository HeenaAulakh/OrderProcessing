using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing.Model;

namespace OrderProcessing.BusinessRules
{
    class DuplicatePackingSlipHandler : BasePaymentProcessing
    {
        protected override bool CanProcess(Payment payment)
        {
            return payment.ProductType == "Book";
        }

        protected override void Process(Payment payment)
        {
            Console.WriteLine("Generate duplicate packing slip for royality department");
        }
    }
}
