using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer4_calculoDaMediaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal inputPrimeiraNota = 0;
            decimal inputSegundaNota = 0;
            decimal resultadoCalculoMedia = 0;
            int quantidadeDenotas = 2;
            int media = 6;

            decimal.TryParse(lblResultado.Text, out resultadoCalculoMedia);

            decimal.TryParse(txtPrimeiraNota.Text, out inputPrimeiraNota);
            decimal.TryParse(txtSegundaNota.Text, out inputSegundaNota);

            resultadoCalculoMedia = (inputPrimeiraNota + inputSegundaNota) / quantidadeDenotas;

            if(resultadoCalculoMedia >= media)
            {
                lblResultado.ForeColor = System.Drawing.Color.Green;
                lblResultado.Text = "Media: " + resultadoCalculoMedia.ToString()+ " \nParabéns aluno(a) aprovado !"; 
                
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "Media: " + resultadoCalculoMedia.ToString() + " \nAluno(a) reprovado !";

            }

            

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiraNota.Text = "";
            txtSegundaNota.Text = "";
            lblResultado.ResetText();
            txtPrimeiraNota.Focus();
        }

        private void txtPrimeiraNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimeiraNota_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        
    }

        private void txtSegundaNota_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8 || e.KeyChar == 44 || e.KeyChar == '.')
            {
                e.Handled = false;
            }
        }

        private void lblPrimeiraNota_Click(object sender, EventArgs e)
        {

        }
    }
}
