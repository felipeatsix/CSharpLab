using System;

namespace practice
{
        // This class will be a COMPONENT of the vending machine - Composition
    public class Display
    {
        // Provides an internal functionality (method) to show a welcome message to customers.
        // We use "public" access modifier because Display could be used in other classes and other assemblies.
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Vending Machine");
        }
    }
}
