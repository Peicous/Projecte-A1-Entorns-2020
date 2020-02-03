using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre1.Text) && !String.IsNullOrEmpty(txtNombre2.Text))
            {
                float a, b, resultat;
                a = float.Parse(txtNombre1.Text);
                b = float.Parse(txtNombre2.Text);
                resultat = a + b;
                txtResultat.Text = resultat.ToString();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre1.Text) && !String.IsNullOrEmpty(txtNombre2.Text))
            {
                float a, b, resultat;
                a = float.Parse(txtNombre1.Text);
                b = float.Parse(txtNombre2.Text);
                resultat = a - b;
                txtResultat.Text = resultat.ToString();
            }
        }

        private void btnMultiplicacio_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre1.Text) && !String.IsNullOrEmpty(txtNombre2.Text))
            {
                float a, b, resultat;
                a = float.Parse(txtNombre1.Text);
                b = float.Parse(txtNombre2.Text);
                resultat = a * b;
                txtResultat.Text = resultat.ToString();
            }
        }

        private void btnDivisio_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre1.Text) && !String.IsNullOrEmpty(txtNombre2.Text) && txtNombre1.Text != "0" && txtNombre2.Text != "0")
            {
                float a, b, resultat;
                a = float.Parse(txtNombre1.Text);
                b = float.Parse(txtNombre2.Text);
                resultat = a / b;
                txtResultat.Text = resultat.ToString();
            }
        }

        private void btnResidu_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre1.Text) && !String.IsNullOrEmpty(txtNombre2.Text) && txtNombre1.Text != "0" && txtNombre2.Text != "0")
            {
                int a, b, resultat;
                a = int.Parse(txtNombre1.Text);
                b = int.Parse(txtNombre2.Text);
                resultat = a % b;
                txtResultat.Text = resultat.ToString();
            }
        }

        private void btnSeq_Click(object sender, EventArgs e)
        {
            int nombre1, nombre2;
            int seq = 0;
            if (!String.IsNullOrEmpty(txtNombre1.Text) && !String.IsNullOrEmpty(txtNombre2.Text))
            {
                nombre1 = int.Parse(txtNombre1.Text);
                nombre2 = int.Parse(txtNombre2.Text);
                txtResultat.Text = "";
                while (seq <= nombre1)
                {
                    txtResultat.Text = txtResultat.Text + "," + seq.ToString();
                    seq = seq + nombre2;
                }
                /*
                for (seq = 0; seq <= nombre1; seq += nombre2)
                {
                    txtResultat.Text = txtResultat.Text + "," + seq.ToString();
                }
                */
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre1.Text) && !String.IsNullOrEmpty(txtNombre2.Text))
            {
                float a, b, resultat, i, total;
                a = float.Parse(txtNombre1.Text);
                b = float.Parse(txtNombre2.Text);
                total = 1;
                for (i = 0; i < b; i++)
                {
                    total = total*a;
                }
                resultat = total;
                txtResultat.Text = resultat.ToString();
            }
        }
    }
}
