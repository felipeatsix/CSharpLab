using System;
using System.Collections.Generic;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>();
            dictionary["name"] = "Felipe";

            // The HttpCookie must have an indexer so we can pass new key/value pairs to it like we do for dictionary.
            var cookie = new HttpCookie(new Dictionary<string, string>());
            cookie["name"] = "Felipe";
            cookie["last name"] = "Santos";
            Console.WriteLine("{0} {1}", cookie["name"], cookie["last name"]);
            Console.WriteLine(dictionary["name"]);
        }
    }
}
