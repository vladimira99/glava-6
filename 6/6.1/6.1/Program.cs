using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++)
                Console.WriteLine(i);
        }
    }
}
