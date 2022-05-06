using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Paciente : Persona
    {
        public string diagnostico;

        public string Diagnostico
        {
            get
            {
                return diagnostico;
            }

            set
            {
                diagnostico = value;
            }
        }

        internal override string FichaExtra()
        {
            StringBuilder ficha = new StringBuilder();
            ficha.AppendLine($"Reside en {this.barrioResidencia}{Environment.NewLine}");
            ficha.AppendLine($"{this.diagnostico}{Environment.NewLine}");

            return ficha.ToString();
        }
        /// <summary>
        /// uso el constructor de base, tiene todo lo necesario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacimiento"></param>
        /// <param name="barrioResidencia"></param>
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : base(nombre, apellido, nacimiento, barrioResidencia)
        { }
    }
}
