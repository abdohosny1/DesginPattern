using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator
{
    public abstract class AbstractDecorator : SMSService
    {
        protected SMSService notificationService;

        public void setService(SMSService sMSService)
        {
            notificationService = sMSService;
        }

        public override string sendSMS(string cudtId, string mobile, string sms)
        {
            if (notificationService != null) { return notificationService.sendSMS(cudtId, mobile, sms); }
            else
            {
                return "Notification Not found";
            }

        }

    }
}
