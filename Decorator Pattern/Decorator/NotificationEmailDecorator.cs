using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator
{
    public class NotificationEmailDecorator :AbstractDecorator
    {

        public string smsSendNotification(string custId,string sms)
        {
            return $" sms {sms}, send to {custId} ,at {DateTime.Now.ToShortDateString()}";
        }
        public override string sendSMS(string cudtId, string mobile, string sms)
        {
            StringBuilder result=new StringBuilder();
            result.AppendLine(base.sendSMS(cudtId, mobile, sms));

            //decorctor method send to email
            result.AppendLine(smsSendNotification(cudtId, sms));
            return result.ToString();

        }

    }
}
