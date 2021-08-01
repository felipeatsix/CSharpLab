using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var blog = new Blog("Learning C#", "Hi this is my blog...");
            var reviewer = new BlogReviewer();
            var publisher = new BlogPublisher();

            Action<Blog> blogReviewHandler = reviewer.TextFormatting;

            publisher.Publish(blog, blogReviewHandler);
        }
    }
}
