using System;

namespace CompositionVsAggregation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new Vending Machine object instance
            var myVendy = new VendingMachine();

            // Access the Display and uses 
            myVendy.Display.WelcomeMessage();

            // Creating Products
            var snack = new Product("Rango Tango", 0.5);
            var drink = new Product("Mineral Water", 0.7);
            var chocolate = new Product("Crunchy", 1);
            var energyDrink = new Product("Red Bull", 3);
            var popcorn = new Product("Caramel pop", 0.5);

            // Inserting Products into machine
            myVendy.InsertProduct(snack);
            myVendy.InsertProduct(drink);
            myVendy.InsertProduct(chocolate);
            myVendy.InsertProduct(energyDrink);
            myVendy.InsertProduct(popcorn);

            // Printing the product in vending machine
            myVendy.PrintProducts();

            // Delete vending machine
            myVendy = null;
            Console.WriteLine("\n!!!!Machine deleted!!!!\n");

            // Display is gone along with the machine
            try
            {
                myVendy.Display.WelcomeMessage();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"The vending machine does not longer exist, therefore the Display is not accessible\nException Message: {e.Message} ");
            }

            // The products still exists
            Console.WriteLine("\nBut products are still here\n");
            snack.PrintDetails();
            drink.PrintDetails();
            chocolate.PrintDetails();
            energyDrink.PrintDetails();
            popcorn.PrintDetails();
        }

    }
}