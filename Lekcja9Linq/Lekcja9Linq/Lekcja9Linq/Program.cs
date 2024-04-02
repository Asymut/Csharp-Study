using System;
using System.Linq;

namespace Lekcja9Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
                int[] arr = { 2, 5, -10, 7, 0, 1, 2, 1, 9, -5 };
                Console.WriteLine(arr.Length);

            arr = arr.Where(x => x > 0).Select(x => x*2).ToArray();

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"First = {arr.FirstOrDefault()}");
            Console.WriteLine($"Sum = {arr.Sum()}");
            Console.WriteLine($"Avg = {arr.Average()}");
            Console.WriteLine($"Max = {arr.Max()}");
            Console.WriteLine($"Min = {arr.Min()}");

               
            
        }
    }
}
    