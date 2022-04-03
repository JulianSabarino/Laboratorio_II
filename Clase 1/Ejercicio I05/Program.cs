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
                if (num <= 2)
                    Console.WriteLine("Ingrese un numero valido");

            } while (num <= 2);

            for(int i = 2; i < num; i++)
            {
                if (Program.IsCenter(i, num))
                    Console.WriteLine(i);
            }

        }

        public static bool IsCenter(int cnum,int num)
        {
            int gauss = DoGauss(cnum - 1);
            int acCnum = 0;
            bool isCenter = false;

            for(int i = (cnum + 1); i <= num; i++)
            {
                acCnum = acCnum + i;
                if (acCnum >= gauss)
                    break;
            }

            if (acCnum == gauss)
                isCenter = true;

            return isCenter;
        }

        static int DoGauss(int num)
        {
            return num * (num + 1) / 2;
        }
    }
}
