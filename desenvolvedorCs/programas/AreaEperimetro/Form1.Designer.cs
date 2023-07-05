namespace AreaEperimetro
{
    partial class frmRetangulo
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
            this.txbComprimento = new System.Windows.Forms.TextBox();
            this.txbLargura = new System.Windows.Forms.MaskedTextBox();
            this.txbArea = new System.Windows.Forms.TextBox();
            this.txbCalcular = new System.Windows.Forms.Button();
            this.txtComprimento = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.Label();
            this.ta1 = new System.Windows.Forms.Label();
            this.txbPerimetro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbComprimento
            // 
            this.txbComprimento.Location = new System.Drawing.Point(91, 12);
            this.txbComprimento.Name = "txbComprimento";
            this.txbComprimento.Size = new System.Drawing.Size(100, 20);
            this.txbComprimento.TabIndex = 0;
            // 
            // txbLargura
            // 
            this.txbLargura.Location = new System.Drawing.Point(91, 38);
            this.txbLargura.Name = "txbLargura";
            this.txbLargura.Size = new System.Drawing.Size(100, 20);
            this.txbLargura.TabIndex = 1;
            // 
            // txbArea
            // 
            this.txbArea.Location = new System.Drawing.Point(91, 64);
            this.txbArea.Name = "txbArea";
            this.txbArea.ReadOnly = true;
            this.txbArea.Size = new System.Drawing.Size(100, 20);
            this.txbArea.TabIndex = 2;
            // 
            // txbCalcular
            // 
            this.txbCalcular.Location = new System.Drawing.Point(207, 62);
            this.txbCalcular.Name = "txbCalcular";
            this.txbCalcular.Size = new System.Drawing.Size(75, 23);
            this.txbCalcular.TabIndex = 3;
            this.txbCalcular.Text = "Calcular";
            this.txbCalcular.UseVisualStyleBackColor = true;
            this.txbCalcular.Click += new System.EventHandler(this.txbCalcular_Click);
            // 
            // txtComprimento
            // 
            this.txtComprimento.AutoSize = true;
            this.txtComprimento.Location = new System.Drawing.Point(9, 12);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(68, 13);
            this.txtComprimento.TabIndex = 4;
            this.txtComprimento.Text = "Comprimento";
            // 
            // txtLargura
            // 
            this.txtLargura.AutoSize = true;
            this.txtLargura.Location = new System.Drawing.Point(22, 38);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(43, 13);
            this.txtLargura.TabIndex = 5;
            this.txtLargura.Text = "Largura";
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(22, 71);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(29, 13);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.Text = "Area";
            // 
            // ta1
            // 
            this.ta1.AutoSize = true;
            this.ta1.Location = new System.Drawing.Point(22, 92);
            this.ta1.Name = "ta1";
            this.ta1.Size = new System.Drawing.Size(51, 13);
            this.ta1.TabIndex = 7;
            this.ta1.Text = "Perimetro";
            // 
            // txbPerimetro
            // 
            this.txbPerimetro.Location = new System.Drawing.Point(91, 89);
            this.txbPerimetro.Name = "txbPerimetro";
            this.txbPerimetro.ReadOnly = true;
            this.txbPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txbPerimetro.TabIndex = 8;
            // 
            // frmRetangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 114);
            this.Controls.Add(this.txbPerimetro);
            this.Controls.Add(this.ta1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.txtComprimento);
            this.Controls.Add(this.txbCalcular);
            this.Controls.Add(this.txbArea);
            this.Controls.Add(this.txbLargura);
            this.Controls.Add(this.txbComprimento);
            this.Name = "frmRetangulo";
            this.Text = "Area e Perimetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbComprimento;
        private System.Windows.Forms.MaskedTextBox txbLargura;
        private System.Windows.Forms.TextBox txbArea;
        private System.Windows.Forms.Button txbCalcular;
        private System.Windows.Forms.Label txtComprimento;
        private System.Windows.Forms.Label txtLargura;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.Label ta1;
        private System.Windows.Forms.TextBox txbPerimetro;
    }
}

