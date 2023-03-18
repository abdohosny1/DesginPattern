using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class BankB : IBank
    {
        public string withDrow()
        {
            return " Your Request is Handle by BankB ";
        }
    }
}
