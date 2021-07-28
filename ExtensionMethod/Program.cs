// What are Extension Methods?

// Allows us to add methods to an existing class without:
// 1. Changing its source code.
// 2. Creating a new class that inherits from it.

using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create new instance of Car
            var car = new Car("white", "Tesla");
            
            // Use a Car method
            car.Move();

            // Use Car EXTENSION method
            // Note that even though "Stop" is a STATIC method, we can only call it from an instance of Car class.
            car.Stop();
        }
    }
}
