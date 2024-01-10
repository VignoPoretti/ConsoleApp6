using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector (2,2);
            Vector v2 = new Vector(3, 3);

            Vector v3 = Vector.Parse("4,4");

            Console.WriteLine("({0}, {1}), ({2}, {3}),  somma ({4}, {5})", v1.X, v1.Y, v2.X, v2.Y, v1.somma(v2).X, v1.somma(v2).Y);

            Console.ReadLine();

        }
    }
}
