using System;

namespace Events
{
    // A class that publishes a document.
    // This class declares a public EventHandler field.
    public class DocumentationPublisher
    {
        public EventHandler<DocumentationPublishedHandler> DocumentationPublished;

        public void Publish(Documentation document)
        {
            Console.WriteLine("Documentation has been published: {0}", document.Title);

            OnDocumentationPublished(document);
        }
        
        protected virtual void OnDocumentationPublished(Documentation document)
        {
            // If the EventHandler field is not null, trigger events.
            if (DocumentationPublished != null)
            {
                DocumentationPublished(this, new DocumentationPublishedHandler(document));
            }
        }
    }
}