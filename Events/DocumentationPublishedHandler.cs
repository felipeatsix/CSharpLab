using System;

namespace Events
{
    public class DocumentationPublishedHandler : EventArgs
    {
        public DocumentationPublishedHandler(Documentation document)
        {
            Document = document;
        }
        public Documentation Document { get; protected set; }
    }
}