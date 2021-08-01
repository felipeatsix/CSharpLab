using System;

namespace ExtensionMethod
{
    // Extension methods should be part of a "static class" as well as its methods and the naming convention should be <class_name>Extensions.
    public static class CarExtensions
    {
        // car parameter is the object instance itself, note that in Program.cs we don't pass anything inside this method.
        public static void Stop(this Car car) 
        {
            Console.WriteLine("Stopping car");
        }
    }
}