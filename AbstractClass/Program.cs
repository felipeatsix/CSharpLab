using System;
using AbstractClass.Shapes;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var triangle = new Triangle();
            circle.DrawToTerminal();
            triangle.DrawToTerminal();
            try
            {
                circle.DrawToFile(@"c:\users\felip\desktop\circle.txt");
                triangle.DrawToFile(@"c:\users\felip\desktop\triangle.txt");
            }
            catch(InvalidOperationException e)
            {
                throw e;
            }
        }
    }
}
