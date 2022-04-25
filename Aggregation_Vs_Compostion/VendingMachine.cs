namespace practice
{
    public class VendingMachine
    {
        // Provides the maximum capacity of the vending machine.
        public static readonly int Capacity = 5;   
        
        // Provides a mechanism that tracks how many products are in the machine.
        private static int _productCount;   
        
        // Provides a "shelf" that can contain up to 5 products.
        private readonly Product[] _productShelf = new Product[5]; 
        
        // Provides and initializes a Display object.
        public Display Display = new Display(); 

        // Provides a public functionality (method) to store products
        public bool InsertProduct(Product item) 
        // This method makes VendingMachine object to AGGREGATE objects of another class (Product), therefore here it happens aggregation instead of composition.
        {
            if (_productCount >= Capacity) return false;
            _productShelf[_productCount] = item;
            _productCount++;
            return true;
        }

        // Provides a public functionality (method) to show products details on screen
        public void PrintProducts()
        {
            for (var i = 0; i < Capacity; i++)
            {
                _productShelf[i].PrintDetails();
            }
        }
    }
}
