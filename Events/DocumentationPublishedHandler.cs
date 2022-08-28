using System;

namespace Events
{
    // A class that derives from EventArgs that takes a document.
    // This class will be responsible to pass a document in the triggered events.
    public class DocumentationPublishedHandler : EventArgs
    {
        public DocumentationPublishedHandler(Documentation document)
        {
            Document = document;
        }
        public Documentation Document { get; protected set; }
    }
}