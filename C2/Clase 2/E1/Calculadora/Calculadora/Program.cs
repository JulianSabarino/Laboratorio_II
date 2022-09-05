using System;
using Calculadora.Calc;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op1, op2,value;
            string operation,bash;

            Calculator.CargarOp("op1", out op1);

            Console.WriteLine("ingrese operacion");
            operation = Console.ReadLine();

            Calculator.CargarOp("op1", out op2);

            value = Calculator.Calcular(op1, op2, operation);
            Console.WriteLine($"{op1} {operation} {op2} = {value}");
        }
    }
}
