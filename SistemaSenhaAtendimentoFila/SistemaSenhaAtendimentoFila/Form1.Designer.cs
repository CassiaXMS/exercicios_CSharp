
namespace SistemaSenhaAtendimentoFila
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovaSenha = new System.Windows.Forms.Button();
            this.btnTamanhoFila = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lstExibirSenha = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovaSenha
            // 
            this.btnNovaSenha.BackColor = System.Drawing.Color.Teal;
            this.btnNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaSenha.Location = new System.Drawing.Point(139, 103);
            this.btnNovaSenha.Name = "btnNovaSenha";
            this.btnNovaSenha.Size = new System.Drawing.Size(217, 30);
            this.btnNovaSenha.TabIndex = 0;
            this.btnNovaSenha.Text = "Gerar novo atendimento";
            this.btnNovaSenha.UseVisualStyleBackColor = false;
            this.btnNovaSenha.Click += new System.EventHandler(this.btnNovaSenha_Click);
            // 
            // btnTamanhoFila
            // 
            this.btnTamanhoFila.BackColor = System.Drawing.Color.Gray;
            this.btnTamanhoFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamanhoFila.Location = new System.Drawing.Point(139, 207);
            this.btnTamanhoFila.Name = "btnTamanhoFila";
            this.btnTamanhoFila.Size = new System.Drawing.Size(217, 30);
            this.btnTamanhoFila.TabIndex = 2;
            this.btnTamanhoFila.Text = "Verificar tamanho da Fila";
            this.btnTamanhoFila.UseVisualStyleBackColor = false;
            this.btnTamanhoFila.Click += new System.EventHandler(this.btnTamanhoFila_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(303, 370);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 33);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lstExibirSenha
            // 
            this.lstExibirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstExibirSenha.FormattingEnabled = true;
            this.lstExibirSenha.ItemHeight = 20;
            this.lstExibirSenha.Location = new System.Drawing.Point(488, 65);
            this.lstExibirSenha.Name = "lstExibirSenha";
            this.lstExibirSenha.Size = new System.Drawing.Size(244, 324);
            this.lstExibirSenha.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Olive;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(139, 262);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(217, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar ordem";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(139, 152);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(217, 30);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar atendimento";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "SISTEMA DE SENHA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lstExibirSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTamanhoFila);
            this.Controls.Add(this.btnNovaSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaSenha;
        private System.Windows.Forms.Button btnTamanhoFila;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lstExibirSenha;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
    }
}

