
namespace OrdenarVetor
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
            this.btnVetor = new System.Windows.Forms.Button();
            this.btnOrdenaVetor = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.lstVetor = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVetor
            // 
            this.btnVetor.Location = new System.Drawing.Point(211, 150);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(75, 23);
            this.btnVetor.TabIndex = 0;
            this.btnVetor.Text = "Vetor";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // btnOrdenaVetor
            // 
            this.btnOrdenaVetor.Location = new System.Drawing.Point(196, 211);
            this.btnOrdenaVetor.Name = "btnOrdenaVetor";
            this.btnOrdenaVetor.Size = new System.Drawing.Size(109, 23);
            this.btnOrdenaVetor.TabIndex = 1;
            this.btnOrdenaVetor.Text = "Ordena Vetor";
            this.btnOrdenaVetor.UseVisualStyleBackColor = true;
            this.btnOrdenaVetor.Click += new System.EventHandler(this.btnOrdenaVetor_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(511, 378);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 2;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // lstVetor
            // 
            this.lstVetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVetor.FormattingEnabled = true;
            this.lstVetor.ItemHeight = 20;
            this.lstVetor.Location = new System.Drawing.Point(443, 71);
            this.lstVetor.Name = "lstVetor";
            this.lstVetor.Size = new System.Drawing.Size(227, 284);
            this.lstVetor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ordenação de vetor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVetor);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.btnOrdenaVetor);
            this.Controls.Add(this.btnVetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.Button btnOrdenaVetor;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.ListBox lstVetor;
        private System.Windows.Forms.Label label1;
    }
}

