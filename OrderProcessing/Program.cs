using OrderProcessing.BusinessRules;
using OrderProcessing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment purchaseOne = new Payment(2.5m, "Book", 253);
            BasePaymentProcessing baseHandler = new PackingSlipHandler();
            BasePaymentProcessing membershipHandler = new MembershipHandler();
            BasePaymentProcessing duplicateSlipHandler = new DuplicatePackingSlipHandler();

            baseHandler.SetNextHandler(duplicateSlipHandler);
            duplicateSlipHandler.SetNextHandler(membershipHandler);

            //Calling chain of responsibility
            baseHandler.ProcessPayment(purchaseOne);

            Console.ReadKey();
        }
    }
}
