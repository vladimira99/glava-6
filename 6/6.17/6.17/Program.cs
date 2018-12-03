using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете второ число: ");
            int b = Int32.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            if (a == 0) Console.WriteLine(b);
            else Console.WriteLine(a);
        }
    }
}
