namespace Inheritance
{
    public class Car : Vehicle
    {
        private readonly int _wheel = 4;
        public new string Color { get; }
        public new double Height { get; }
        public new double Width { get; }

        public Car(string color, double height, double width) : base(color, height, width)
        {
            Color = color;
            Height = height;
            Width = width;
            Wheel = _wheel;
        }
    }
}