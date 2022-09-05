using System;

namespace E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Julian", "Sabarino", "40640332");
            e1.NotaPrimerParcial = 4;
            e1.NotaSegundoParcial = 4;
            e1.Mostrar();
        }
    }
}
