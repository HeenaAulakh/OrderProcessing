using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing.Model;

namespace OrderProcessing.BusinessRules
{
    class MembershipHandler : BasePaymentProcessing
    {
        protected override bool CanProcess(Payment payment)
        {
            return payment.ProductType == "Membership";
        }

        protected override void Process(Payment payment)
        {
            Console.WriteLine("Activate membership account");
        }
    }
}
