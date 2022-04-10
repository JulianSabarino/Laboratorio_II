using System;

namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            double altura;
            double radius;
            AreaCalculator areaCalculator = new AreaCalculator();

            Console.WriteLine("Ingrese lado de un cuadrado");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Area {0}",areaCalculator.CalcularAreaCuadrado(lado));

            Console.WriteLine("Ingrese base de un triangulo");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura de un triangulo");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Area {0}", areaCalculator.CalcularAreaTriangulo(lado,altura));

            Console.WriteLine("Ingrese radio");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area {0}", areaCalculator.CalcularAreaCirculo(radius));
        }
    }

    public class AreaCalculator
    {  
        public double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado,2);
        }

        public double CalcularAreaTriangulo(double fbase, double altura)
        {
            return altura * fbase/2;
        }

        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio,2); 
        }


    }
}
