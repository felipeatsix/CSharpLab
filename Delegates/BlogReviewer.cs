using System;

namespace Delegates
{
    public class BlogReviewer
    {
        public void TextFormatting(Blog blog)
        {
            Console.WriteLine("Applying text formatting");
        }
    }

    public class BlogRating
    {
        public void Rate(Blog blog)
        {
            Console.WriteLine("Applying blog rate");
        }
    }
}