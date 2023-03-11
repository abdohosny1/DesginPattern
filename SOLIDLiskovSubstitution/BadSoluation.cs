//using System;
//using System.Collections.Generic;

//namespace SOLIDLiskovSubstitution
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            PostDatabase db = new PostDatabase();
//            List<string> newPosts = new List<string>();
//            newPosts.Add("original post");
//            newPosts.Add("#tag post");
//            newPosts.Add("@mention post");
//            Post postObj;
//            foreach (var post in newPosts)
//            {
//                if (post.StartsWith("#"))
//                {
//                    postObj = new TagPost();

//                }
//                else if (post.StartsWith("@"))
//                {
//                    postObj = new MentionPost();
//                }
//                else
//                {
//                    postObj = new Post();
//                }
//                string result = postObj.CreatePost(db, post);
//                Console.WriteLine(result);
//            }
//            Console.ReadKey();
//        }
//    }

//    public class Post
//    {
//        public virtual string CreatePost(PostDatabase db, string post)
//        {
//            return db.Add(post);
//        }
//    }
//    public class TagPost : Post
//    {
//        public string CreateTagPost(PostDatabase db, string post)
//        {
//            return db.AddTagPost(post);
//        }
//    }

//    public class MentionPost : Post
//    {
//        public string CreateMentionPost(PostDatabase db, string post)
//        {
//            return db.AddMentionPost(post);
//        }
//    }


//}
//    }
