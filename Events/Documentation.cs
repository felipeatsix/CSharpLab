namespace Events
{
    // A simple class with twi properties.
    public class Documentation
    {
        public Documentation(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public string Title { get; protected set; }
        public string Text { get; protected set; }
    }
}