using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class HREvalHandler : BaseHandler
    {
        //handelr case 1
        //public override void HandleRequest(JopApplication request)
        //{
        //    request.Comments.AppendLine("HR Comment");

        //    if(_nextHandler != null)
        //    {
        //        _nextHandler.HandleRequest(request);
        //    }
        //    else {
        //        request.Comments.AppendLine("End by HR handler");
        //    }
        //}


        //handel case 2
        //public override void HandleRequest(JopApplication request)
        //{
        //    if (request.JopCode == "456")
        //    {
        //        request.Comments.AppendLine("HR Comment");

        //    }
        //    else
        //    {
        //        if (_nextHandler != null)
        //        {
        //            _nextHandler.HandleRequest(request);
        //        }
        //        else
        //        {
        //            request.Comments.AppendLine("End by HR handler");
        //        }
        //    }

        void ToNext(JopApplication request)
        {

            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                request.Comments.AppendLine("End by HR handler");
            }
        }
        public override void HandleRequest(JopApplication request)
        {
            if (request.JopCode == "456")
            {
                request.Comments.AppendLine("HR Comment");
                ToNext(request);
            }
            else
            {
                ToNext(request);
            }

        }
    }
}
