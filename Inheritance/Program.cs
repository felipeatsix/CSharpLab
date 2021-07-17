using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("red", 1.4, 4.7);
            var motorcycle = new Motorcycle("blue", 1.12, 1.12);
            
            Console.WriteLine("The color of the {0} is {1}", car.GetType().Name, car.Color);
            Console.WriteLine("The color of the {0} is {1}", motorcycle.GetType().Name, motorcycle.Color);
            
            car.StartEngine();
            motorcycle.StartEngine();
            car.StopEngine();
            motorcycle.StopEngine();
        }
    }
}
