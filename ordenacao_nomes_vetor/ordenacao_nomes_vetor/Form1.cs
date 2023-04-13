using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenacao_nomes_vetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                lblOrdemNomes.Text = ("Digite o " + i + "° nome: ");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstVetorNomes.Items.Clear();
        }

        private void txtNomes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String nome = txtNomes.Text;

            txtNomes.ResetText();
            txtNomes.Focus();
            lstVetorNomes.Items.Add(nome);
            int cont = lstVetorNomes.Items.Count;
            
            
            if (cont >= 5)
            {
                txtNomes.Enabled = false;
                btnEnviar.Enabled = false;
                txtNomes.Text = "Qtd de nomes alcançada!";
            }


        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
        }

        private void lblOrdemNomes_Click(object sender, EventArgs e)
        { 
        }

        private void btnOrdenarNomes_Click(object sender, EventArgs e)
        {
            int contador = lstVetorNomes.Items.Count;
            String[] nome = new String[contador];

            lblOrdemNomes.Text = ("Digite o ° nome: ");

            for (int i=0; i<contador; i++)
            {
                nome[i] = lstVetorNomes.Items[i].ToString();
            }

            Array.Sort(nome);
            lstVetorNomes.Items.Clear();



            lstVetorNomes.Items.Add("Valores ordenados: ");
            foreach(String item in nome)
            {
                lstVetorNomes.Items.Add(item);
            }

        }
    }
}
