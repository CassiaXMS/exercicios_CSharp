using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSenhaAtendimentoFila
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        Queue<string> filaAtendimento = new Queue<string>();

        private void btnNovaSenha_Click(object sender, EventArgs e)
        {
            filaAtendimento.Enqueue("Sen14a");
            filaAtendimento.Enqueue("Sen15b");
            filaAtendimento.Enqueue("Sen16c");
            filaAtendimento.Enqueue("Sen17d");
            filaAtendimento.Enqueue("Sen18e");

            lstExibirSenha.Items.Add(filaAtendimento.Peek());

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            lstExibirSenha.Items.Add("Atendimento finalizado!");
            filaAtendimento.Dequeue();

        }

        private void btnTamanhoFila_Click(object sender, EventArgs e)
        {
            int contador = filaAtendimento.Count;
            lstExibirSenha.Items.Add("Tamanho da fila: " + contador);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            foreach (string senha in filaAtendimento)
            {
                lstExibirSenha.Items.Add(senha);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
