using System;

namespace ExtensionMethod
{
    // Note that this class is a "sealed class" this means it can't be inherited by other classes.
    // We will add another method to be used with an instance of this class using an Extension method.
    public sealed class Car
    {
        public Car(string color, string model)
        {
            Color = color;
            Model = model;
        }

        public string Color { get; set; }
        public string Model { get; set; }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}