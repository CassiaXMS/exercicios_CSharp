using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarVetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            int[] numeros = { 7, 9, 10, 8, 6, 5 };

            lstVetor.Items.Add("Primeiro valor: " + numeros[0]);
            lstVetor.Items.Add("Segundo valor: " + numeros[1]);
            lstVetor.Items.Add("Terceiro valor: " + numeros[2]);
            lstVetor.Items.Add("Quarto valor: " + numeros[3]);
            lstVetor.Items.Add("Quinto valor: " + numeros[4]);
            lstVetor.Items.Add("Sexto valor: " + numeros[5]);



        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            lstVetor.Items.Clear();
        }

        private void btnOrdenaVetor_Click(object sender, EventArgs e)
        {
            int[] numeros = { 7, 9, 10, 8, 6, 5 };

            lstVetor.Items.Add("Valores antes da ordenação: ");
            for (int x = 0; x < 6; x++){
                lstVetor.Items.Add((x+1) + " ° Valor: " + numeros[x]);
            }
            Array.Sort(numeros);

            lstVetor.Items.Add("Valores após a ordenação: ");
            for (int x = 0; x < 6; x++)
            {
                lstVetor.Items.Add((x + 1) + " ° Valor: " + numeros[x]);
            }

        }
    }
}
