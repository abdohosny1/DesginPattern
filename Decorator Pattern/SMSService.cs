using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class SMSService
    {
        public abstract string sendSMS(string cudtId, string mobile, string sms);
    }
}
