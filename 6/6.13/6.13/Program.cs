using System;
namespace _6._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToString(n, 2));
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
