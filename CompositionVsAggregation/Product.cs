using System;

namespace CompositionVsAggregation
{
    public class Product
        // This class will be CONTAINED by the vending machine - Aggregation
    {
        private readonly string _name;
        private readonly double _price;

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        // Provides a public functionality (method) to show product details on screen
        // We use "public" access modifier because Product could be used in other classes and other assemblies.
        public void PrintDetails()
        {
            Console.WriteLine($"[{_name} : ${_price}]");
        }
    }
}