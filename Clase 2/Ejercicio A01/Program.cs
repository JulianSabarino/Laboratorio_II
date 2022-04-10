using System;

namespace Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int factorialNum = int.Parse(Console.ReadLine());

            Console.WriteLine("!{0} = {1}",factorialNum,CalculateFactorial(factorialNum));

        }

        static int CalculateFactorial(int number)
        {
            int acumulator = 1;
            if (number > 0)
            {
                acumulator = number;
                for (int i = (number - 1); i > 1; i--)
                {
                    acumulator = acumulator * i;
                }
            }
            else
            {
                if(number < 0)
                    acumulator = 0;
            }

            return acumulator;
        }
    }
}
