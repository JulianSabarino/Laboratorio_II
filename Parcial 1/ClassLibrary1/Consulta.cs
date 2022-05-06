using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }

        public Paciente Paciente
        {
            get
            {
                return paciente;
            }
        }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }
        /// <summary>
        /// formateo para que al hacer consulta.ToString() me devuelva FECHA se ha atendido a PACIENTE
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder nombreCompleto = new StringBuilder();
            nombreCompleto.Append(string.Format($"{this.Fecha} se ha atendido {this.Paciente}"));
            return nombreCompleto.ToString();
        }
    }
}
