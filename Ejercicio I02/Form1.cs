using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace Ejercicio_I02
{
    public partial class frm_ing : Form
    {
        public Dictionary<string, string> paisesProv = new Dictionary<string,string>();

        public enum paises
        {
            Argentina,
            Brazil,
            ZonaSur
        }

        public enum appendList
        {
            country,
            course
        }

        private void FillDictionary()
        {
            
            paisesProv.Add("Entre Rios",paises.Argentina.ToString());
            paisesProv.Add("Buenos Aires",paises.Argentina.ToString());
            paisesProv.Add("Catamarca",paises.Argentina.ToString());

            paisesProv.Add("Brasilia",paises.Brazil.ToString());
            paisesProv.Add("Sao Paulo",paises.Brazil.ToString());

            paisesProv.Add("Quilmes",paises.ZonaSur.ToString());
            paisesProv.Add("Bernal",paises.ZonaSur.ToString());
            paisesProv.Add("Lanus",paises.ZonaSur.ToString());
            paisesProv.Add("Avellaneda",paises.ZonaSur.ToString());
            paisesProv.Add("Crucesitas", paises.ZonaSur.ToString());
        }

        private void AppendCmbPaises()
        {
            cmb_paises.Items.Add(paises.Argentina.ToString());
            cmb_paises.Items.Add(paises.Brazil.ToString());
            cmb_paises.Items.Add(paises.ZonaSur.ToString());
        }

        private void AppendLstPaises(string pais)
        {
            foreach (string city in paisesProv.Keys)
            {
                if (paisesProv[city] == pais)
                    AppendToList(city);
            }
        }

        public frm_ing()
        {
            InitializeComponent();
            
            /*
            this.lstb_paises.Items.Add("Argentina");
            AppendToList("Brazil",appendList.country);

            this.lstb_paises.Items.Add("Zona Sur");
            AppendToList("Croacia", appendList.country);

            this.lstb_paises.Items.Add("Chile");
            */

            this.chlb_ocourse.Items.Add("Linux");
            AppendToList("Photoshop", appendList.course);

            this.chlb_ocourse.Items.Add("Assembler");
            AppendToList("English", appendList.course);
            

            AppendCmbPaises();
            FillDictionary();

            this.cal_borndate.MaxSelectionCount = 1;
            this.cal_borndate.ShowToday = false;
            this.cal_borndate.ShowTodayCircle = false;
        }

        private void btn_ing_Click(object sender, EventArgs e)
        {
            List<string> courseList = new List<string>();

            string name = txt_name.Text;
            string surname = txt_surname.Text;
            string dir = txt_dir.Text;
            string altura = txt_altura.Text;

            DateTime borndate = new DateTime();

            string country;

            genre genero = genre.Masculino;
            if (grb_fem.Checked)
                genero = genre.Femenino;

            User user;

            if (CanPushUser() > 0)
            {
                country = lstb_paises.SelectedItem.ToString();

                borndate = cal_borndate.SelectionRange.Start;

                AppendCourses(courseList);

                user = new User(name,surname,dir,altura,borndate,country,genero);
                user.setCourses(courseList);

                MessageBox.Show(user.GetData());
            }
        }

        private bool AppendToList(string value)
        {
            return AppendToList(value,appendList.country);
        }

        private bool AppendToList(string value, appendList type)
        {
            bool retValue = true;
            switch (type)
            {
                case appendList.country:
                    this.lstb_paises.Items.Add((string)value);
                    break;
                case appendList.course:
                    this.chlb_ocourse.Items.Add(((string)value));
                    break;
                default:
                    retValue = false;
                    break;
            }
            return retValue;
        }

        private int AppendCourses(List<string> list)
        {
            int counter = 0;
            if (chb_cpp.Checked)
            {
                list.Add(chb_cpp.Text);
                counter++;
            }
            if (chb_cs.Checked)
            { 
                list.Add(chb_cs.Text);
                counter++;
            }
            if(chb_js.Checked)
            {
                list.Add(chb_js.Text);
                counter++;
            }


            foreach (string course in chlb_ocourse.CheckedItems)
            {
                list.Add(course);
                counter++;
            }
                  
            return counter;
        }

        private int CanPushUser()
        {
            int counter = 0;

            if (chb_cpp.Checked)
                counter++;          
            if (chb_cs.Checked)
                counter++;  
            if (chb_js.Checked)
                counter++;
            foreach (string course in chlb_ocourse.CheckedItems)
                counter++;

            if (counter == 0)
                MessageBox.Show("Ingrese Cursos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            if (txt_name.Text == "" && counter > 0)
            {
                counter = -1;
                MessageBox.Show("Error al Cargar el Nombre","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            if (txt_surname.Text == "" && counter > 0)
            {
                counter = -1;
                MessageBox.Show("Error al Cargar el Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((txt_dir.Text == "" || txt_altura.Text == "") && counter > 0)
            {
                counter = -1;
                MessageBox.Show("Error al Cargar el Direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (lstb_paises.SelectedIndex < 0 && counter > 0)
            {
                counter = -1;
                MessageBox.Show("Error al Cargar el Pais", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cal_borndate.SelectionRange == null && counter > 0)
            {
                counter = -1;
                MessageBox.Show("Error al Cargar la Fecha de Nacimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((grb_masc.Checked == false && grb_fem.Checked == false) && counter > 0)
            {
                counter = -1;
                MessageBox.Show("Error al Cargar el Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return counter;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void cmb_paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstb_paises.Items.Clear();
            AppendLstPaises(cmb_paises.Text);
        }
    }
}
