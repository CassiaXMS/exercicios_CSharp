using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer3_numero_macasForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtQuantidadeDigitada.Text = "";
            lblResultado.ResetText();
            txtQuantidadeDigitada.Focus();

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int inputQuantidade;
            double resultadoCalculo = 0.0;

            resultadoCalculo = Convert.ToDouble(resultadoCalculo);
            int.TryParse(txtQuantidadeDigitada.Text, out inputQuantidade);

            if(inputQuantidade < 12)
            {
                resultadoCalculo = inputQuantidade * 1.30;
                lblResultado.Text = "Custo Total = R$ " + resultadoCalculo.ToString("N2");
            }else
            { 
                resultadoCalculo = inputQuantidade * 1.00;
                
                lblResultado.Text = "Custo Total = R$ " + resultadoCalculo.ToString("N2");
            }
        }

        private void txtQuantidadeDigitada_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidadeDigitada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
