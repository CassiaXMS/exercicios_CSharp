
namespace ordenarQuinzeNumerosBubbleSort
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstVetor = new System.Windows.Forms.ListBox();
            this.btnExibirVetor = new System.Windows.Forms.Button();
            this.btnOrdenarVetor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenação de numeros";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(542, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstVetor
            // 
            this.lstVetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVetor.FormattingEnabled = true;
            this.lstVetor.ItemHeight = 20;
            this.lstVetor.Location = new System.Drawing.Point(449, 70);
            this.lstVetor.Name = "lstVetor";
            this.lstVetor.Size = new System.Drawing.Size(269, 324);
            this.lstVetor.TabIndex = 5;
            // 
            // btnExibirVetor
            // 
            this.btnExibirVetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirVetor.Location = new System.Drawing.Point(168, 159);
            this.btnExibirVetor.Name = "btnExibirVetor";
            this.btnExibirVetor.Size = new System.Drawing.Size(132, 30);
            this.btnExibirVetor.TabIndex = 6;
            this.btnExibirVetor.Text = "Números";
            this.btnExibirVetor.UseVisualStyleBackColor = true;
            this.btnExibirVetor.Click += new System.EventHandler(this.btnExibirVetor_Click);
            // 
            // btnOrdenarVetor
            // 
            this.btnOrdenarVetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarVetor.Location = new System.Drawing.Point(168, 230);
            this.btnOrdenarVetor.Name = "btnOrdenarVetor";
            this.btnOrdenarVetor.Size = new System.Drawing.Size(132, 30);
            this.btnOrdenarVetor.TabIndex = 7;
            this.btnOrdenarVetor.Text = "Ordenar vetor";
            this.btnOrdenarVetor.UseVisualStyleBackColor = true;
            this.btnOrdenarVetor.Click += new System.EventHandler(this.btnOrdenarVetor_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrdenarVetor);
            this.Controls.Add(this.btnExibirVetor);
            this.Controls.Add(this.lstVetor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox lstVetor;
        private System.Windows.Forms.Button btnExibirVetor;
        private System.Windows.Forms.Button btnOrdenarVetor;
    }
}

