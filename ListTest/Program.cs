using System;
using System.Collections.Generic;
namespace ListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine(HolaMundo());
        }

        public string HolaMundo()
        {
            return "Hola Mundo";
        }

        private int addLista(List<string> lista)
        {
            lista.Add("a");
            lista.Add("b");
            lista.Add("c");

            return 3;
        }

    }



}
