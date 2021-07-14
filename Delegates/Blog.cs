using System;

namespace Delegates
{
    public class Blog
    {
        public Blog(string title, string body)
        {
            Title = title;
            Body = body;
        }

        public string Title { get; protected set; }
        public string Body { get; protected set; }

        internal void Publish()
        {
            Console.WriteLine("{0}: {1} ({2})", "Blog published", Title, Body);
        }
    }
}