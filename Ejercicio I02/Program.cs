using System;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un numero:");
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                    Console.WriteLine("El numero ingresado no puede ser 0 \n");
            } while (num == 0);

            Program.SquareCube(num);
        }

        static void SquareCube(int num)
        {
            Console.WriteLine("Numero para cuadrado y cubo: ");
            Console.WriteLine("Numero: {0} Cuadrado: {1} Cubo: {2}", num, Math.Pow(num, 2), Math.Pow(num, 3));
        }
    }
}
