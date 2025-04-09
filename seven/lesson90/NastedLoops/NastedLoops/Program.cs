namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested Loops
            List<Product> products = new List<Product>();
            products.Add(new Product("Pfanne", new List<int> { 1, 2, 4 }));
            products.Add(new Product("Grill", new List<int> { 5, 4, 3 }));
            products.Add(new Product("Topf", new List<int> { 5, 2, 5 }));
            products.Add(new Product("Herd", new List<int> { 6, 7, 6 }));


            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == "Grill") //hier wird der Grill übersprungen
                {
                    continue;
                }

                    Console.WriteLine("Produkt " + products[i].Name);
                for (int j = 0; j < products[i].Ratings.Count; j++)
                {
                    Console.WriteLine($"Das {products[i].Ratings[j]} hat eine Sternebewertung");

                    if (products[i].Ratings[j] == 1)
                    {
                        Console.WriteLine("Dieses Produkt ist schlecht bewertet");
                        break;
                    }
                }
            }

            // foreach ist sehr viel einfacher
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