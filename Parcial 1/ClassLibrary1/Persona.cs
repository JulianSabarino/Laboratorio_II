using System;
using System.Text;

namespace Personas
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// toma a la persona y acopla su nombre y apellido
        /// </summary>
        /// <returns>APELLIDO, NOMBRE</returns>

        public override string ToString()
        {
            StringBuilder nombreCompleto = new StringBuilder();
            nombreCompleto.Append(string.Format($"{this.apellido}, {this.nombre}"));
            return nombreCompleto.ToString();
        }

        internal abstract string FichaExtra();

        /// <summary>
        /// Escribe todos los datos de la persona, fue modificado para que compile FichaPersonal(Persona persona) -> FichaPersonal()
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public string FichaPersonal()
        {
            StringBuilder ficha =  new StringBuilder();
            ficha.Append($"{this.ToString()}{Environment.NewLine}");
            ficha.Append($"EDAD:{this.Edad}{Environment.NewLine}");
            ficha.Append($"{this.FichaExtra()}");

            return ficha.ToString();
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nacimiento = nacimiento;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;   
        }

    }
}
