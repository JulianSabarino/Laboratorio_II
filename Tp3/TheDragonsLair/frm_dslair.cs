using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMnProd;


namespace TheDragonsLair
{
    public partial class frm_dslair : Form
    {
        private List<PrimaryWH> primaryWHs;
        private List<SecondaryWH> secondaryWHs;
        public frm_dslair()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            primaryWHs = new List<PrimaryWH>();
            secondaryWHs = new List<SecondaryWH>();

            primaryWHs.Add(new PrimaryWH("Deposito 1", "Faraday 1400"));
            primaryWHs.Add(new PrimaryWH("Deposito 2", "Faraday 1500"));

            foreach (PrimaryWH primary in primaryWHs)
            {
                lstb_primaryWH.Items.Add(primary);
            }

            PrimaryWH depo = (PrimaryWH)primaryWHs.Find(x => x.Name == "Deposito 1");
            depo.AddSecondaryWH(new SecondaryWH("Deposito 1.1", "Faraday 1400"));
            depo.AddSecondaryWH(new SecondaryWH("Deposito 1.2", "Faraday 1410"));

            depo.AddProduct(new Boardgame("Gloom Heaven", 4));

            depo = (PrimaryWH)primaryWHs.Find(x => x.Name == "Deposito 2");
            depo.AddSecondaryWH(new SecondaryWH("Deposito 2.1", "Faraday 1500"));
            depo.AddSecondaryWH(new SecondaryWH("Deposito 2.2", "Faraday 1510"));
            depo.AddSecondaryWH(new SecondaryWH("Deposito 3.2", "Faraday 1520"));

            depo.AddProduct(new Cards("Españolas", Cards.Type.Gambling));

            SecondaryWH depo2 = depo.SecondaryWHs.Find(x => x.Name == "Deposito 2.1");
            depo2.AddProduct(new Props("Goliath Barbarian", Props.Type.Mini));

            btn_load.Enabled = false;

            

            
            /*
            Boardgame bgame1 = new Boardgame("Gloom Heaven", 4);

            depo1.AddProduct(bgame1);
            depo1.AddProduct(new Cards("Españolas", Cards.Type.Gambling));
            depo1.AddProduct(new Props("Goliath Barbarian", Props.Type.Mini));

            foreach (Product product in depo1.Products)
            {
                lstb_Prod.Items.Add((Product)product);
            }
            */
            
        }

        private void lstb_primaryWH_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstb_secondaryWH.Items.Clear();

            PrimaryWH depo = lstb_primaryWH.SelectedItem as PrimaryWH;
            foreach (SecondaryWH secondary in depo.SecondaryWHs)
            {
                lstb_secondaryWH.Items.Add(secondary);
            }
        }

        private void lstb_primaryWH_Click(object sender, EventArgs e)
        {
            lstb_Prod.Items.Clear();
            PrimaryWH depo = lstb_primaryWH.SelectedItem as PrimaryWH;
            if (depo != null && depo.Products.Count > 0)
            {
                foreach (Product product in depo.Products)
                {
                    lstb_Prod.Items.Add(product);
                }
            }
        }

        private void lstb_secondaryWH_Click(object sender, EventArgs e)
        {
            lstb_Prod.Items.Clear();
            SecondaryWH depo = lstb_secondaryWH.SelectedItem as SecondaryWH;
            if (depo != null && depo.Products.Count > 0)
            {
                foreach (Product product in depo.Products)
                {
                    lstb_Prod.Items.Add(product);
                }
            }
        }

        private void btn_newMovement_Click(object sender, EventArgs e)
        {
            frm_newMovement frm = new frm_newMovement();
            frm.ShowDialog();
        }
    }
}
