using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing.Model;

namespace OrderProcessing.BusinessRules
{
    class VideoPaymentHandler : BasePaymentProcessing
    {
        protected override bool CanProcess(Payment payment)
        {
            return payment.ProductType == "Video";
        }

        protected override void Process(Payment payment)
        {
            Console.WriteLine("Add free 'First Aid' video to packing slip for order: {0}", payment.Reference);
        }
    }
}
