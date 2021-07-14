using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie(Dictionary<string, string> dictionary)
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Declare indexer

        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }
    }
}