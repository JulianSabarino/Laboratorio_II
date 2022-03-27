using System;

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un numero entero positivo");
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num <= 0)
                    Console.WriteLine("Ingrese un numero valido");

            } while (num <= 0);

            Program.PrintCenter(num);

        }

        static void PrintCenter(int num)
        {
            int cont = 0;

            int acHi = num;
            int acLow = 0;
/*
            do
            {
                acHi = acHi + (acHi - 1);
                acLow = acLow + (acLow + 1);
                cont++;

                Console.WriteLine("Hi:{0} Low:{1} cont:{2}",acHi, acLow,cont);
                Console.ReadKey();

            }while (acLow < acHi && cont < num);
*/
            Console.WriteLine(cont);
        }

        static int FindCenter(int num)
        {
            return 0;
        }
    }
}
