using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class ConcereteSMSService : SMSService
    {
        public override string sendSMS(string cudtId, string mobile, string sms)
        {
            return $"CustomerId {cudtId} sms send  to {mobile}";
        }
    }
}
