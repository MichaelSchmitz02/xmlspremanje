using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Zadatak
{
    public partial class Form1 : Form
    {
        List<Vozila> listaVozila = new List<Vozila>();
        Vozila osoba = new Vozila();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)

        {
            // Osoba osoba = new Osoba();
            try
            {
                Vozila vozila = new Vozila(txtMarka.Text, txtModel.Text, Convert.ToInt16(txtGodina.Text), Convert.ToInt16(txtKilometraza.Text));



                txtMarka.Clear();
                txtModel.Clear();
                txtGodina.Clear();
                txtKilometraza.Clear();
                txtMarka.Focus();

                DialogResult upit = MessageBox.Show("Želi teli unesti još podataka", "Upit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        {
                            listaVozila.Add(vozila);
                            break;
                        }
                    case DialogResult.No:
                        {
                            listaVozila.Add(vozila);
                            txtMarka.Enabled = false;
                            txtModel.Enabled = false;
                            txtGodina.Enabled = false;
                            txtKilometraza.Enabled = false;
                            break;
                        }
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogrešan unos"
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }

}

        

    
