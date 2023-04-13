using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exer2_numeroPositivoNegativoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputNumero;

            int.TryParse(txtNumero.Text, out inputNumero);

            if(inputNumero < 0)
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "Numero negativo !";
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Green;
                lblResultado.Text = "Numero positivo !";
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = " ";
            lblResultado.ResetText();
            txtNumero.Focus();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
