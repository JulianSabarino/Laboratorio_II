using System;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor miConvertidor = new Conversor();
            int entero;

            Console.WriteLine("Ingrese un numero Entero para convertirlo en Binario");
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero {0} es {1} en binario",entero,miConvertidor.ConvertirDecimalABinario(entero));

            Console.WriteLine("Ingrese un numero Binario para convertirlo en Entero");
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero {0} es {1} en decimal", entero, miConvertidor.ConvertirBinarioADecimal(entero));

        }
    }

    public class Conversor
    {
        public string ConvertirDecimalABinario(int numeroEntero)
        {
            return (Convert.ToString(numeroEntero, 2));
        }

        public int ConvertirBinarioADecimal(int numeroEntero)
        {
            return Convert.ToInt32(numeroEntero.ToString(), 2);
        }
    }

}
