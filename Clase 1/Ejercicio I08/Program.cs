using System;
using System.Text;

namespace Ejercicio_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            
            Console.WriteLine("Ingrese una altura");
            do
            {
                altura = int.Parse(Console.ReadLine());
                if (altura < 1)
                    Console.WriteLine("Altura invalida");
            } while (altura < 1);

            StringBuilder triangle = new StringBuilder("",altura);

            for (int i = 1; i <= altura; i++)
            {
                triangle.Clear();



                for (int j = 1; j <= i; j++)
                {
                    triangle.Append("*");
                }
                Console.WriteLine(triangle.ToString());
                }
            }

        }
    }
}
