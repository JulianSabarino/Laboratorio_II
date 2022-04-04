using System;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max;
            int min;
            Console.WriteLine("Ingrese limite inferior.");
            min = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese limite superior.");
            max = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numero.");
            num = int.Parse(Console.ReadLine());

            if (Validar(num, min, max))
            {
                Console.WriteLine("Esta en rango");
            }
            else
            {
                Console.WriteLine("No esta en rango");
            }
        }

        static bool Validar(int valor, int min, int max)
        {
            return (valor >= min && valor <= max);
        }

    }
}
