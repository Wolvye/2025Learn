namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested Loops
            List<Product> products = new List<Product>();
            products.Add(new Product("Pfanne", new List<int> { 3, 2, 1 }));
            products.Add(new Product("Grill", new List<int> { 5, 4, 3 }));
            products.Add(new Product("Topf", new List<int> { 5, 2, 5 }));



            ////Durchlaufen aller Produkte
            //foreach (Product product in products) //OuterLoop
            //{
            //    Console.WriteLine("Produkt: " + product.Name);//InnerLoop
            //    foreach(int rating in product.Ratings)
            //    {
            //        Console.WriteLine($"{rating} Sterne für das Produkt");
            //    }
            //}
        }
    }

    internal class Product
    {
        public string Name { get; private set; }

        public List<int> Ratings { get; private set; }

        public Product(string name, List<int> ratings)
        {
            Name = name;
            Ratings = ratings;
        }
    }

}