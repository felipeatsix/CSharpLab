using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Documentation("Title", "some documentation text...");
            var publisher = new DocumentationPublisher();
            var slackMessage = new SlackMessage();

            publisher.DocumentationPublished = slackMessage.OnDocumentationPublished;

            publisher.Publish(document);
        }
    }
}
