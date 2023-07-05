namespace IMC
{
    partial class frmIMC
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
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(146, 48);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(255, 48);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(146, 18);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.AutoSize = true;
            this.txtAltura.Location = new System.Drawing.Point(12, 48);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(128, 13);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.Text = "Digite A Altura em metros:";
            // 
            // txtPeso
            // 
            this.txtPeso.AutoSize = true;
            this.txtPeso.Location = new System.Drawing.Point(22, 18);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(108, 13);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.Text = "Digite o Peso em KG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado";
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(146, 77);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(100, 20);
            this.txbResultado.TabIndex = 7;
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 100);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbAltura);
            this.Name = "frmIMC";
            this.Text = "Desafio IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label txtAltura;
        private System.Windows.Forms.Label txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbResultado;
    }
}

