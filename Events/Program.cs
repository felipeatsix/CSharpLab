using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Documentation("Title", "some documentation text blablabla...");
            var publisher = new DocumentationPublisher();
            var slackMessage = new SlackService();

            publisher.DocumentationPublished = slackMessage.OnDocumentationSent;

            publisher.Publish(document);
        }
    }
}
