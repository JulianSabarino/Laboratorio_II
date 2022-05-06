using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        /// <summary>
        /// Hago un override del Ficha extra para poder mostrar todas las consultas
        /// </summary>
        /// <returns></returns>

        internal override string FichaExtra()
        {
            StringBuilder ficha = new StringBuilder();

            ficha.AppendLine($"Finalizo residencia: {this.esResidente}{Environment.NewLine}");
            foreach (Consulta consulta in consultas)
            {
                ficha.AppendLine($"{consulta.ToString()}{Environment.NewLine}");
            }

            return ficha.ToString();
        }

        /// <summary>
        /// Agrego una consulta y devuelvo personal medico para poder hacer +=
        /// </summary>
        /// <param name="personalMedico"></param>
        /// <param name="consulta"></param>
        /// <returns></returns>

        public static PersonalMedico operator +(PersonalMedico personalMedico, Consulta consulta)
        {
            personalMedico.consultas.Add(consulta);
            return personalMedico;
        }

        /// <summary>
        /// cuando creo un medico creo una lista
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacimiento"></param>
        /// <param name="esResidente"></param>

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            consultas = new List<Consulta>();
            this.esResidente = esResidente;
        }

    }
}
