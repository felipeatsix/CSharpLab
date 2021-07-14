using System;

namespace BasicClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var felipe = new Human(new DateTime(1989, 03, 27));
            Console.WriteLine(felipe.Age);
        }
    }
}
