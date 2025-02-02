namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(1001, "Laptop", 1200.50, 10);

            Console.WriteLine("Product Details:");
            Console.WriteLine($"Product ID: {product.ProdID}");
            Console.WriteLine($"Product Name: {product.ProdName}");
            Console.WriteLine($"Item Price: {product.ItemPrice:C}");
            Console.WriteLine($"Stock Amount: {product.StockAmount}");

            Console.WriteLine("\nIncreasing stock...");
            product.IncreaseStock(5);
            Console.WriteLine($"New Stock Amount: {product.StockAmount}");

            Console.WriteLine("\nDecreasing stock...");
            product.DecreaseStock(3);
            Console.WriteLine($"New Stock Amount: {product.StockAmount}");
        }
    }
}
