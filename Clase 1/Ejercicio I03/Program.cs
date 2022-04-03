using System;

namespace Ejercicio_I03
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
                    Console.WriteLine("El numero ingresado no puede ser 0 \n");
            } while (num <= 0);

            Alabama(num);
        }

        static void Alabama(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
        }

        static bool IsPrime(int num)
        {
            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }

}
