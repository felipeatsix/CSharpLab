using System;

namespace Delegates
{
    public class BlogPublisher
    {
        public void Publish(Blog blog, Action<Blog> blogReviewHandler)
        {
            blogReviewHandler(blog);
            blog.Publish();
        }
    }
}