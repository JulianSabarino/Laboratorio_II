using System;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: ");
            string newTitular = Console.ReadLine();

            Cuenta cuenta = new Cuenta(newTitular, 0);

            cuenta.Mostrar();

            cuenta.Ingresar(1200);
            cuenta.Mostrar();

            cuenta.Retirar(300);
            cuenta.Mostrar();

        }
    }

    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string newTitular, double newCantidad)
        {
            titular = newTitular;
            cantidad = newCantidad;
        }
        public void Mostrar()
        {
            Console.Write("{0} {1} {2}", titular, cantidad, Environment.NewLine);
        }

        public double Ingresar(double monto)
        {
            cantidad = cantidad + monto;
            return cantidad;
        }

        public double Retirar(double monto)
        {
            cantidad = cantidad - monto;
            return cantidad;
        }
    }
}
