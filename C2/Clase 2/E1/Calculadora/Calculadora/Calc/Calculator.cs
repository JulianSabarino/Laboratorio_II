using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Calc
{
    public static class Calculator
    {
        static public int  Calcular(int op1, int op2, string operation)//podemos hacer que devuelva un object para que devuelva false o un valor
        {

            int result = 0;
            switch (operation)
            {
                case "x":

                    result = op1 * op2;
                    break;
                case "+":
                    result = op1 + op2;
                    break;
                case "-":
                    result = op1 - op2;
                    break;
                case "/":
                    if (Validar(op2))
                    {
                        result = op1 / op2;
                    }
                    else
                    {
                        Console.WriteLine("Math Error");
                    }
                    break;
                default:
                    Console.WriteLine("Syntax Error");
                    break;
                }
                return result;
        }

        private static bool Validar(int valor)
        {
            bool retorno = true;
            if (valor == 0)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool CargarOp(string bash, out int valor)
        {
            string stdinput;
            bool parseOk;
            Console.WriteLine($"Ingrese numero {bash}");
            stdinput = Console.ReadLine();
            parseOk = int.TryParse(stdinput, out valor);

            if(!parseOk)
                valor = 0;

            return parseOk;
        }
    }
}
