using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenarQuinzeNumerosBubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstVetor.Items.Clear();
        }

        private void btnExibirVetor_Click(object sender, EventArgs e)
        {
            int[] numeros  = { 45, 23, -4, 22, 60, 120, 2, 0, 77, -89, 10, 11, 4, 11, 5};

            for (int i = 0; i < numeros.Length; i++)
            {
                lstVetor.Items.Add(numeros[i]);
            }
        }

        private void btnOrdenarVetor_Click_1(object sender, EventArgs e)
        {
            int[] numeros = { 45, 23, -4, 22, 60, 120, 2, 0, 77, -89, 10, 11, 4, 11, 5 };
            int t = 15;
            int i, j, k = 0;

            for (i = 0; i < t - 1; i++)
            {
                for (j = 0; j < t - (i + 1); j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        k = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = k;
                    }
                }
            }

            for (i = 0; i < numeros.Length; i++)
            {
                lstVetor.Items.Add(numeros[i]);
            }
        }
    }
}

