using System;
namespace Inheritance
{
    public class Vehicle
    {
        public Vehicle(string color, double height, double width)
        {
            Color = color;
            Height = height;
            Width = width;
        }

        public string Color { get; protected set; }
        public double Height { get; protected set; }
        public double Width { get; protected set; }
        public int Wheel { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Start {0} engine", this.GetType().Name);
        }
        
        public void StopEngine()
        {
            Console.WriteLine("Stop {0} engine", this.GetType().Name);
        }
    }
}