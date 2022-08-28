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
            var rating = new BlogRating();

            Action<Blog> blogReviewHandler = reviewer.TextFormatting;
            blogReviewHandler += rating.Rate;

            publisher.Publish(blog, blogReviewHandler);
        }
    }
}
