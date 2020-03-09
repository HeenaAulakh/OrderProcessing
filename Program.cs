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
            Payment purchaseOne = new Payment(2.5m, "Book", 250);
            Payment purchaseTwo = new Payment(10m, "Membership", 251);
            Payment purchaseThree = new Payment(17m, "Physical", 252);
            Payment purchaseFour = new Payment(5.75m, "UpgradeMembership", 253);
            Payment purchaseFive = new Payment(7.59m, "Video", 254);

            BasePaymentProcessing baseHandler = new PackingSlipHandler();
            BasePaymentProcessing membershipHandler = new MembershipHandler();
            BasePaymentProcessing upgradeMembershipHandler = new UpgradeMembershipHandler();
            BasePaymentProcessing duplicateSlipHandler = new DuplicatePackingSlipHandler();
            BasePaymentProcessing commisionPaymentHandler = new CommissionPaymentHandler();
            BasePaymentProcessing videoPaymentHandler = new VideoPaymentHandler();

            baseHandler.SetNextHandler(duplicateSlipHandler);
            baseHandler.SetNextHandler(commisionPaymentHandler);
            duplicateSlipHandler.SetNextHandler(membershipHandler);
            membershipHandler.SetNextHandler(upgradeMembershipHandler);
            commisionPaymentHandler.SetNextHandler(videoPaymentHandler);

            //Calling chain of responsibility
            baseHandler.ProcessPayment(purchaseOne);
            membershipHandler.ProcessPayment(purchaseTwo);
            baseHandler.ProcessPayment(purchaseThree);
            membershipHandler.ProcessPayment(purchaseFour);
            baseHandler.ProcessPayment(purchaseFive);

            Console.ReadKey();
        }
    }
}
