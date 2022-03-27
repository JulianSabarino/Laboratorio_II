using System;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int acNum = 1;
            do
            {
                if (isPerfect(acNum))
                {
                    Console.WriteLine(acNum);
                    cont++;
                }
                acNum++;
//                Console.WriteLine(acNum);
//                Console.ReadKey();
            } while (cont < 4);
        }

        static bool isPerfect(int num)
        {
            bool isPerfect = false;
            int acumulator = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    acumulator=acumulator + i;
                if (acumulator > num)
                    break;
            }

            if (acumulator == num)
                isPerfect = true;

            return isPerfect;
        }
    }
}
