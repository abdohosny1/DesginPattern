using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;

        public void SetNext(BaseHandler baseHandler)
        {
            _nextHandler = baseHandler;
        }

        public abstract void HandleRequest(JopApplication request);
    }
}
