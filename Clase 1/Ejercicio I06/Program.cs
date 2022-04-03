using System;

namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Ingrese un a;o a evaluar");

            do
            {
                year = int.Parse(Console.ReadLine());
                if (year < 1)
                    Console.WriteLine("A;o invalida");
            } while (year < 1);

            //Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} es bisiesto", year);
            }
            else
            {
                Console.WriteLine("{0} no es bisiesto", year);
            }
        }
    }
}
