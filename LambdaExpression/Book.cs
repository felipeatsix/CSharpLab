using System.Collections.Generic;

namespace LambdaExpression
{
    public class Book
    {
        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}