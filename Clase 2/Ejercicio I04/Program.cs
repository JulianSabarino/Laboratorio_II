using System;
using System.Text;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            float calculated;
            calculator.AddToKeyboard();
            calculator.AdtoScreen();
            if (calculator.AdOperation())
            {
                calculator.AddToKeyboard();
                calculated = calculator.Calculate();
                Console.WriteLine(calculated);
            }
            else
                Console.WriteLine("Syntax Error");
            
        }
    }

    public class Calculator
    {
        private float memory;
        private float screen;
        private float keyboarded;
        private string opearation;

        public Calculator()
        {
            Console.WriteLine("Bienvenido a Calculadora 2022");
        }

        public float AddToKeyboard()
        {
            float newNumber = float.Parse(Console.ReadLine());
            keyboarded = newNumber;

            return newNumber;
        }

        public void AdtoScreen()
        {
            screen = keyboarded;
        }

        public bool AdOperation()
        {
            opearation = Console.ReadLine();
            return (opearation == "x" || opearation == "-" || opearation == "+" || opearation == "/");
        }

        public float Calculate()
        { 
            float result = 0;
            switch (opearation)
            {
                case "x":
                    result = Multiplication(screen, keyboarded);
                    break;
                case "+":
                    result = Sumatory(screen, keyboarded);
                    break;
                case "-":
                    result = Difference(screen, keyboarded);
                    break;
                case "/":
                    result = Division(screen, keyboarded);
                    break;
                default:
                    Console.WriteLine("Syntax Error");
                    break;
            }
            memory = result;
            return result;
        }

        private float Multiplication(float memNum, float keyNum)
        {
            return memNum * keyNum;
        }

        private float Sumatory(float memNum, float keyNum)
        {
            return memNum + keyNum;
        }

        private float Difference(float memNum, float keyNum)
        {
            return memNum - keyNum;
        }

        private float Division(float memNum, float keyNum)
        {
            return memNum / keyNum;
        }
    }
}
