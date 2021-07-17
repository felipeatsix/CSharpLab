using System;

namespace Events
{
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
            if (DocumentationPublished != null)
            {
                DocumentationPublished(this, new DocumentationPublishedHandler(document));
            }
        }
    }
}