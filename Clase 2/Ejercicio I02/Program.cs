using System;
using System.Text;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inNumber;
            Validador acumulator = new Validador();
            StringBuilder doNextKa = new StringBuilder("",3);

            do
            {
                Console.WriteLine("Ingrese numero a sumar");
                inNumber = int.Parse(Console.ReadLine());

                acumulator.SumarValor(inNumber);

                doNextKa.Clear();
                Console.WriteLine("Desea continuar?");
                doNextKa.Append(Console.ReadLine());

            }while(acumulator.ValidarRespuesta(doNextKa));

            Console.WriteLine("La suma total es: {0}",acumulator.ObtenerValor());
        }
    }

    class Validador
    {
        private int suma = 0;
        public int ObtenerValor()
        {
            return suma;
        }

        public void SumarValor(int valor)
        {
            suma = suma + valor;
        }

        public bool ValidarRespuesta(StringBuilder respuesta)
        {
            return (respuesta.ToString().Equals("S"));
        }

    }
}
