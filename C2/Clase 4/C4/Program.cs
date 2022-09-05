using C4.Classes;
using System;

namespace C4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto prod = new Producto("Mayonesa");
            Console.WriteLine(prod.ToString());

            Producto prod2 = new Producto("Queso", 5);
            Console.WriteLine(prod2.ToString());

            prod2.Precio = 7;
            Console.WriteLine(prod2.ToString());
            prod.Precio = 3;
            Console.WriteLine(prod.ToString());

            Console.WriteLine("{0}",prod+prod2);
            
            prod.Stock = prod + 15;
            prod2.Stock = prod + 3;
            prod.Stock = prod - 4;

            Console.WriteLine("{0} {1}",prod.Stock, prod2.Stock);

            Console.WriteLine("{0}", prod == prod2);

        }
    }
}
