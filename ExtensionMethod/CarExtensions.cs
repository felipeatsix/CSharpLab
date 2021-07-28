// Extension methods should be part of a "static class" as well as its methods should also be static and the naming convention should be <class name it extends>Extensions.

using System;

namespace ExtensionMethod

{
    public static class CarExtensions
    {
        public static void Stop(this Car car) // car parameter is the object instance itself, note that in Program.cs we don't pass anything inside this method.
        {
            Console.WriteLine("Stopping car");
        }
    }
}