//Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

//using System.ComponentModel.DataAnnotations;

//bool Validar(int valor, int min, int max)

//valor: dato a validar.
//min: mínimo valor incluido.
//max: máximo valor incluido.
//Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

//Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.


//using vala =  C2.Ejercicios.Validador; // recordar que hace el using automatico
using C2.Ejercicios; // esto es el namespace
using System;
using System.ComponentModel.DataAnnotations;



namespace C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stdinput;
            int valor;
            int min = 0;
            int max = 0;
            int acumulator = 0;
            bool parseOk;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese numero {i+1}");
                    stdinput = Console.ReadLine();
                    parseOk = int.TryParse(stdinput, out valor);
                } while (!parseOk || !Validador.Validar(valor, -100, 100));

                if (i == 0)
                {
                    min = valor;
                    max = valor;
                }

                if (min > valor)
                {
                    min = valor;
                }

                if (max < valor)
                {
                    max = valor;
                }

                acumulator+=valor;
            }
            Console.WriteLine($"El promedio fue {acumulator/10}, el valor minimo y maximo fueron {min} {max}");
        }
    }
}
