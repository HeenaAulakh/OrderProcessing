using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing.Model;

namespace OrderProcessing.BusinessRules
{
    class UpgradeMembershipHandler : BasePaymentProcessing
    {
        protected override bool CanProcess(Payment payment)
        {
            return payment.ProductType == "UpgradeMembership";
        }

        protected override void Process(Payment payment)
        {
            Console.WriteLine("Upgrade membership account & email user for order : {0}", payment.Reference);
        }
    }
}
