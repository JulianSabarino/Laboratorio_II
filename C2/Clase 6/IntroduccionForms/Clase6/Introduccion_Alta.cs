using Clase6.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase6
{
    public partial class Introduccion_Alta : Form
    {
        private User _usuario;
        public Introduccion_Alta()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string pass = txt_pass.Text;
            _usuario = new User(nombre, pass);
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public User Usuario
        {
            get { return _usuario; }
        }
    }
}
