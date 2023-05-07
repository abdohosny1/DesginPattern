using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class TechnicalEvalHandler : BaseHandler
    {

        // first  use pattern 
        //public override void HandleRequest(JopApplication request)
        //{
        //    request.Comments.AppendLine("Technical comment");
        //    if (_nextHandler != null)
        //    {
        //        _nextHandler.HandleRequest(request);
        //    }
        //    else
        //    {
        //        request.Comments.AppendLine("End by Technical handler");
        //    }
        //}

        //handle case 2
        //public override void HandleRequest(JopApplication request)
        //{

        //    if (request.JopCode == "123")
        //    {
        //        request.Comments.AppendLine("Technical comment");

        //    }
        //    else
        //    {
        //        if (_nextHandler != null)
        //        {
        //            _nextHandler.HandleRequest(request);
        //        }
        //        else
        //        {
        //            request.Comments.AppendLine("End by Technical handler");
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
                request.Comments.AppendLine("End by Technical handler");
            }
        }
        public override void HandleRequest(JopApplication request)
        {

            if (request.JopCode == "123")
            {
                request.Comments.AppendLine("Technical comment");
                ToNext(request);

            }
            else
            {
                ToNext(request);
            }

      

        }
    }
}
