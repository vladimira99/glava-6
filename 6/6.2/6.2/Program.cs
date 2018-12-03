using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число N: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++)
            {
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }
        }
    }
}
