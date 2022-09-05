using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personas;

namespace SabarinoJulian_Parcial1
{
    public partial class frm_Sabarino : Form
    {
        public frm_Sabarino()
        {
            InitializeComponent();
        }

        private void frm_Sabarino_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Fede", "Dávila", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Esteban", "Prieto", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Diego", "Cagna", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Alfredo", "Moreno", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Blas", "Giunta", new DateTime(1912, 12, 12), "La Boca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellín"));
        }

        /// <summary>
        /// Cuando aprete me fijo si ambos estan seleccionados, si lo estan busco sus objetos y les hago los procedimientos
        /// una vez termino hago un refresh forzoso del richboxtext_medicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_atender_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItems.Count > 0 && lstPacientes.SelectedItems.Count > 0)
            {

                Paciente paciente = (Paciente)lstPacientes.SelectedItem;
                paciente.Diagnostico = "Paciente Curado";

                PersonalMedico? medico = lstMedicos.SelectedItem as PersonalMedico;
                Consulta consulta = new Consulta(DateTime.Now, paciente);

                medico += consulta;
             
                MessageBox.Show(consulta.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //lstMedicos.ClearSelected(); //Tira Error
                //lstPacientes.ClearSelected();


                string mensaje = medico.FichaPersonal();
                rtb_infoMedicos.Text = mensaje;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar","ERROR EN LOS DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalMedico medico = (PersonalMedico)lstMedicos.SelectedItem;
            string mensaje = medico.FichaPersonal();
            rtb_infoMedicos.Text = mensaje;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Sabarino_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (opcion == DialogResult.No)
                e.Cancel = true;
        }
    }
}
