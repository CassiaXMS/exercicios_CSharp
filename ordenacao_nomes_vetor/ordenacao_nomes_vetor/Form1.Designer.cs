
namespace ordenacao_nomes_vetor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lstVetorNomes = new System.Windows.Forms.ListBox();
            this.lblOrdemNomes = new System.Windows.Forms.Label();
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnOrdenarNomes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenação de nomes";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(369, 176);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lstVetorNomes
            // 
            this.lstVetorNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVetorNomes.FormattingEnabled = true;
            this.lstVetorNomes.ItemHeight = 20;
            this.lstVetorNomes.Location = new System.Drawing.Point(517, 103);
            this.lstVetorNomes.Name = "lstVetorNomes";
            this.lstVetorNomes.Size = new System.Drawing.Size(210, 264);
            this.lstVetorNomes.TabIndex = 2;
            // 
            // lblOrdemNomes
            // 
            this.lblOrdemNomes.AutoSize = true;
            this.lblOrdemNomes.Location = new System.Drawing.Point(104, 138);
            this.lblOrdemNomes.Name = "lblOrdemNomes";
            this.lblOrdemNomes.Size = new System.Drawing.Size(35, 13);
            this.lblOrdemNomes.TabIndex = 3;
            this.lblOrdemNomes.Text = "label2";
            this.lblOrdemNomes.Click += new System.EventHandler(this.lblOrdemNomes_Click);
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(107, 178);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(229, 20);
            this.txtNomes.TabIndex = 4;
            this.txtNomes.TextChanged += new System.EventHandler(this.txtNomes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite cinco nomes";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(583, 373);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnOrdenarNomes
            // 
            this.btnOrdenarNomes.Location = new System.Drawing.Point(172, 239);
            this.btnOrdenarNomes.Name = "btnOrdenarNomes";
            this.btnOrdenarNomes.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarNomes.TabIndex = 8;
            this.btnOrdenarNomes.Text = "Ordenar";
            this.btnOrdenarNomes.UseVisualStyleBackColor = true;
            this.btnOrdenarNomes.Click += new System.EventHandler(this.btnOrdenarNomes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrdenarNomes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomes);
            this.Controls.Add(this.lblOrdemNomes);
            this.Controls.Add(this.lstVetorNomes);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lstVetorNomes;
        private System.Windows.Forms.Label lblOrdemNomes;
        private System.Windows.Forms.TextBox txtNomes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnOrdenarNomes;
    }
}

