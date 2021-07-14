using System;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var blog = new Blog("Learning C#", "Hi this is my blog...");
            var reviewer = new BlogReviewer();
            var publisher = new BlogPublisher();

            Action<Blog> blogPublishHandler = reviewer.BlogTheme;
            blogPublishHandler += reviewer.Formatting;

            publisher.Publish(blog, blogPublishHandler);
        }
    }
}
