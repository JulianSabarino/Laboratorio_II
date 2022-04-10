using System;

namespace Ejercicio_I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h;
            double b;

            Console.WriteLine("Ingrese base de un triangulo");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura de un triangulo");
            b = double.Parse(Console.ReadLine());

            RectangleTriangle triangle = new RectangleTriangle(h, b);

            Console.WriteLine("La hipotenusa mide {0:.##} cm", triangle.CalculatePitagoras());
        }
    }

    public class RectangleTriangle
    {
        private double haltura;
        private double fbase;

        public RectangleTriangle(double h, double b)
        {
            haltura = h;
            fbase = b;
        }

        public double CalculatePitagoras()
        {
            return Math.Sqrt(Math.Pow(haltura,2) + Math.Pow(fbase,2));
        }

    }
}
