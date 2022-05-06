using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01
{
    public partial class frm_holaForm : Form
    {
        public frm_holaForm()
        {
            InitializeComponent();
        }

        private void btn_hola_Click(object sender, EventArgs e)
        {
            string caption = "Hola " + this.txt_nombre.Text + " " + this.txt_apellido.Text;
            string message = "Desea Continuar?";

            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }

            this.txt_nombre.Clear();
            this.txt_apellido.Clear();

        }
    }
}
