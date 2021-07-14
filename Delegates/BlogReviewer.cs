using System;

namespace Delegates
{
    public class BlogReviewer
    {
        public void Formatting(Blog blog)
        {
            Console.WriteLine("Applying blog formatting");
        }

        public void BlogTheme(Blog blog)
        {
            Console.WriteLine("Apply blog theme");
        }
    }
}