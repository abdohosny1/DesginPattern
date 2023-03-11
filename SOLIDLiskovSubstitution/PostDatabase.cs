using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLiskovSubstitution
{
    public class PostDatabase
    {
        public string Add(string post)
        {
            return "Original Post: " + post;
        }
        public string AddTagPost(string post)
        {
            return "Tag post: " + post;
        }
        public string AddMentionPost(string post)
        {
            return "Mention post: " + post;
        }
    }
}
