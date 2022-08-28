using System;

namespace Delegates
{
    public class BlogPublisher
    {
        public void Publish(Blog blog)
        {
            Console.WriteLine($"Publishing blog: {blog.Title}");
        }
        public void Publish(Blog blog, Action<Blog> blogReviewHandler)
        {
            blogReviewHandler(blog);
            Console.WriteLine($"Publishing blog: {blog.Title}");
        }
    }
}