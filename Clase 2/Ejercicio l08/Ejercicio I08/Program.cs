using System;

namespace Ejercicio_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startingDate;
            string[] splitDate;
            DateTime startingDDate;
            string[] days;

            Console.WriteLine("Ingrese una fecha");
            startingDate = Console.ReadLine();
            splitDate = startingDate.Split('/');
            
            startingDDate = new DateTime(int.Parse(splitDate[2]), int.Parse(splitDate[1]), int.Parse(splitDate[0]));

            days = ((DateTime.Now - startingDDate).ToString()).Split('.');

            Console.WriteLine(days[0]);
        }
    }
}
