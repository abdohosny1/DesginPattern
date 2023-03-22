using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    internal interface IBankFactory
    {
        public IBank GetBank(string bankCode);
        IPaymentCard GetPaymentCard(string cardNumber);
    }
}
