using OrderProcessing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.BusinessRules
{
    public abstract class BasePaymentProcessing
    {
        private BasePaymentProcessing NextHandler;

        public void SetNextHandler(BasePaymentProcessing Nexthandler)
        {
            this.NextHandler = NextHandler;
        }
        public void ProcessPayment(Payment payment)
        {
            if (CanProcess(payment))
                Process(payment);
            if (NextHandler != null)
                NextHandler.ProcessPayment(payment);
        }

        protected abstract bool CanProcess(Payment payment);
        protected abstract void Process(Payment payment);
    }
}
