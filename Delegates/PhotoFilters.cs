using System;

namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyResize(Photo photo)
        {
            Console.WriteLine("Apply resize");
        }

        public void ApplyShadow(Photo photo)
        {
            Console.WriteLine("Apply shadow");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }
    }
}