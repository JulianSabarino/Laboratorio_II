using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    public class Estudiante
    {
        private string _appellido;
        private string _legajo;
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static int _random;

        public Estudiante(string nombre, string appellido, string legajo)
        {
            _nombre = nombre;
            _appellido = appellido;
            _legajo = legajo;
        }

        static Estudiante()
        {
            Random rnd = new Random();
            _random = rnd.Next();
        }

        public int NotaPrimerParcial
        {
            set { _notaPrimerParcial = value; }
            get { return _notaPrimerParcial; }
        }

        public int NotaSegundoParcial
        {
            set { _notaSegundoParcial = value; }
            get { return _notaSegundoParcial; }
        }

        private float CalcularPromedio()
        {
            return (this.NotaPrimerParcial + this.NotaSegundoParcial) / 2;
        }

        private double CalcularNotaFinal()
        {
            double nota = -1;
            if (this.NotaPrimerParcial >= 4 && this.NotaSegundoParcial >= 4)
            {
                Random rnd = new Random();
                nota = rnd.Next(6,11);
            }
            return nota;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{_nombre} {_appellido} {_legajo}");
            sb.AppendLine($"{this.NotaPrimerParcial} {this.NotaSegundoParcial}");
            sb.AppendLine($"{CalcularPromedio()}");
            double notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"{notaFinal}");
            }
            Console.Write(sb.ToString());
        }
    }


}
