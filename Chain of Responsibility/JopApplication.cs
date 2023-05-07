using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
   public class JopApplication
    {
        public string ApplicationName { get; set; }
        public string jopTitle { get; set; }
        public string JopCode { get; set; }
        public StringBuilder Comments { get; set; }

        public string showComment() { return Comments.ToString(); }
    }
}
