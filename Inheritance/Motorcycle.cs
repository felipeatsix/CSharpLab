namespace Inheritance
{
    public class Motorcycle : Vehicle
    {
        private readonly int _wheel = 2;
        public new string Color { get; }
        public new double Height { get; }
        public new double Width { get; }

        public Motorcycle(string color, double height, double width) : base(color, height, width)
        {
            Color = color;
            Height = height;
            Width = width;
            Wheel = _wheel;
        }
    }
}