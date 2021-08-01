using System;

namespace Delegates
{
    public class BlogPublisher
    {
        public void Publish(Blog blog, Action<Blog> blogReviewHandler)
        {
            blogReviewHandler(blog);
            Console.WriteLine("Publishing blog: {0}", blog.Title);
        }
    }
}