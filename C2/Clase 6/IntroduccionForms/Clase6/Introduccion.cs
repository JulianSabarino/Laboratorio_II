using Clase6.Classes;

namespace Clase6
{
    public partial class Introduccion : Form
    {
        private List<User> usuarios;
        public Introduccion()
        {
            InitializeComponent();
            usuarios = new List<User>();
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            lbl_name.Text = txt_nombre.Text;
            if (txt_nombre.Text != "")
            {
                rtxt_historial.AppendText(txt_nombre.Text);
                rtxt_historial.AppendText(Environment.NewLine);
                lstb_historial.Items.Add(txt_nombre.Text);
            }
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No hay todavia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Introduccion_Alta f2 = new Introduccion_Alta();
            DialogResult d2 = f2.ShowDialog();
            if (d2 == DialogResult.OK)
            {
                usuarios.Add(f2.Usuario);
                lstb_historial.Items.Add(f2.Usuario);
                rtxt_historial.AppendText(f2.Usuario.ToString());
                rtxt_historial.AppendText(Environment.NewLine);
            }
            else
            {
                MessageBox.Show("No se pudo cargar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}