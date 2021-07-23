using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a list of books
            var bookList = new List<Book>
            {
                new Book("Title 1", 10.00),
                new Book("Title 2", 15.00),
                new Book("Title 3", 20.00),
                new Book("Title 4", 30.00),
                new Book("Title 5", 40.00)
            };

            // Use lambda expression to find all books that costs 20 Euros or less.
            var cheapBooks = bookList.FindAll(b => b.Price <= 20.00);            
            
            // Use lambda expression to find all books that costs 20 Euros or less.
            var expensiveBooks = bookList.FindAll(b => b.Price > 20.00);

            // Iterate through the result of cheapBooks and write it on the console.
            Console.WriteLine("Books less than 20 Euros:");
            foreach (var book in cheapBooks)
            {
                Console.WriteLine("Title: {0}, Price: {1}", book.Title, book.Price);
            }            
            // Iterate through the result of expensiveBooks and write it on the console.
            Console.WriteLine("\nBooks more than 20 Euros:");
            foreach (var book in expensiveBooks)
            {
                Console.WriteLine("Title: {0}, Price: {1}", book.Title, book.Price);
            }
        }
    }
}
