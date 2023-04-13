using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer5_verificacaoDeVotoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int inputAnoAtual;
            int inputAnoNascimento;
            int resultadocalculo;

            int.TryParse(txtAnoAtual.Text, out inputAnoAtual);
            int.TryParse(txtNascimento.Text, out inputAnoNascimento);
            int.TryParse(txtAnoAtual.Text, out inputAnoAtual);

            resultadocalculo = (inputAnoAtual - inputAnoNascimento);
            if (resultadocalculo >= 18)
            {

                lblResultado.ForeColor = System.Drawing.Color.Green;
                lblResultado.Text = (" Sim, você já pode votar!");

            }
            else
            {

                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = (" Não, você não pode votar!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAnoAtual.Text = "";
            txtNascimento.Text = "";
            lblResultado.ResetText();
            txtAnoAtual.Focus();
        }

        private void txtAnoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }


        }

        private void txtNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }


        }
    }
}
