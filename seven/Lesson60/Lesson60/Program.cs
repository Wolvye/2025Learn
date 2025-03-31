using System.Diagnostics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<int> list = new List<int>();

            list.Add(100);
            list.Add(-100);
            list.Add(500);
            list.Add(1060);
            

            bool success = list.Remove(100);

            list.Clear();

            list.Insert(4, 80);

            list.RemoveAt(4);

            int index = list.IndexOf(500);

            int count = list.Count;
        }
    }
}