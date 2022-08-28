namespace Inheritance
{
    public class Car : Vehicle
    {
        public new string Color { get; }
        public new double Height { get; }
        public new double Width { get; }
        public new int Wheel { get; protected set; }

        public Car(string color, double height, double width) : base(color, height, width)
        {
            Color = color;
            Height = height;
            Width = width;
            Wheel = 4;
        }
    }
}