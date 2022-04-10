using System;
using System.Text;
namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para mostrar la tabla");
            int initNumber = int.Parse(Console.ReadLine());

            MultiplicationTable table = new MultiplicationTable(initNumber);
            table.ShowTable();
        }
    }

    public class MultiplicationTable
    {
        private int tableNumber;

        public MultiplicationTable(int initNumber)
        {
            tableNumber = initNumber;
        }

        public void ShowTable()
        {
            StringBuilder myText = new StringBuilder();

            myText.AppendFormat("{0} x",tableNumber);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} {1} = {2}",myText,i,tableNumber*i);
            }
        }
    }
}
