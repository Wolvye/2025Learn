namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe: Wie oft kommt jede Zahl vor.
            //Versuche es mit einem Dictionary zu lösen

            int[] numbers = new int[10]
                {
                    10,20,40,90,50,10,20,40,90,50
                };

            Dictionary<int,int> numbersCount = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                numbersCount.Add(number, 1);
            }

        }
    }
}