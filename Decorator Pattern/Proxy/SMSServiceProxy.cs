using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator
{
    public class SMSServiceProxy
    {
        private SMSService _SMSService;
        Dictionary<string, int> SendCOUNT = new Dictionary<string, int>();

        public string sendSms(string cudtId, string mobile, string sms)
        {
            if (_SMSService == null) {_SMSService=new ConcereteSMSService();}

            //fitst call
            if(!SendCOUNT.ContainsKey(cudtId)) 
            { 
                SendCOUNT.Add(cudtId, 1);
                return _SMSService.sendSMS(cudtId, mobile, sms);
            }
            else
            {
               var customer=SendCOUNT.Where(x=>x.Key== cudtId).FirstOrDefault();    

                if(customer.Value >= 2) 
                { return "not send message";
                }
                else
                {
                    SendCOUNT[cudtId] = customer.Value + 1;
                     return _SMSService.sendSMS(cudtId, mobile, sms);

                }
            }

        }

    }
}
