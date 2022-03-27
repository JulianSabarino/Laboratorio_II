using System;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] IntArray = new int[5];
            string endl = "\n";

            Console.WriteLine("Ingrese 5 numeros:");

            for (int i = 0; i < IntArray.Length; i++)
                IntArray[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("El minimo es:" + Program.Min(IntArray));
            Console.WriteLine("El maximo es:" + Program.Max(IntArray));
            Console.WriteLine("El promedio es:" + Program.Prom(IntArray));
        }

        static int Min(int[] IntArray)
        {
            int min = 0;
            if (IntArray != null)
            {
                min = IntArray[0];
                for (int i = 1; i < IntArray.Length; i++)
                {
                    if (Math.Min(IntArray[i], min) < min)
                        min = IntArray[i];
                }
            }
            return min;
        }

        static int Max(int[] IntArray)
        {
            int max = 0;
            if (IntArray != null)
            {
                max = IntArray[0];
                for (int i = 1; i < IntArray.Length; i++)
                {
                    if (Math.Max(IntArray[i], max) > max)
                        max = IntArray[i];
                }
            }
            return max;
        }

        static int Prom(int[] IntArray)
        {
            int prom = 0;
            if (IntArray != null)
            {
                for (int i = 0; i < IntArray.Length; i++)
                {
                    prom += IntArray[i];
                }
                prom = prom / IntArray.Length;
            }
            return prom;
        }
    }
}
