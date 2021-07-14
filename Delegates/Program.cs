using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.ApplyResize;
            filterHandler += filters.ApplyShadow;

            processor.Process(@"c:\users\felipe\images\test.png", filterHandler);
        }
    }
}
