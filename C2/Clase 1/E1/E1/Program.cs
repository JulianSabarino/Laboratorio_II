using System;

namespace E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio: declarar y asignar una variable del tipo string
            // Calcular su longitud
            // Si es mayor a 5, mostrar 'Es mayor a 5'
            // De lo contrario, mostrar 'Es menor a 5'
            // Si es igual a 5, mostrar 'Es igual a 5'
            // Cambiar el color de la consola a azul
            // Cambiar la letra de la consola a a blanco
            // Hacer un 'beep' al iniciar el programa

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();

            string nombre;
            int largo;
            Console.WriteLine("Ingrese un nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Cuantas letras cree que tiene?");
            largo = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out largo);
            if (nombre.Length == largo)
            {
                Console.WriteLine($"Asi es, {nombre} tiene {largo} letras");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
