using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> FilterHandler)
        {
            var photo = Photo.Load(path);

            // FilterHandler will contain PhotoFilters methods
            FilterHandler(photo);

            photo.Save();
        }
    }
}