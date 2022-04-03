using System;
using System.Text;
namespace Ejercicio_I09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int bottom;
            Console.WriteLine("Ingrese una altura");
            do
            {
                altura = int.Parse(Console.ReadLine());
                if (altura < 1)
                    Console.WriteLine("Altura invalida");
            } while (altura < 1);

            bottom = (altura * 2) - 1;

            StringBuilder triangle = new StringBuilder("", bottom);

            for (int i = 1; i <= (altura*2); i++)
            {
                if (i % 2 == 1)
                {
                    triangle.Clear();
                    int spaces = (bottom - i)/2;

                    for (int j = 0; j < spaces; j++)
                    {
                        triangle.Append(' ');
                    }

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
