namespace OperadoresAritmeticos
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txbNumero1 = new TextBox();
            txbNumero2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbResultado = new TextBox();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Número 1:";
            // 
            // txbNumero1
            // 
            txbNumero1.Location = new Point(78, 6);
            txbNumero1.Name = "txbNumero1";
            txbNumero1.Size = new Size(100, 23);
            txbNumero1.TabIndex = 1;
            // 
            // txbNumero2
            // 
            txbNumero2.Location = new Point(78, 35);
            txbNumero2.Name = "txbNumero2";
            txbNumero2.Size = new Size(100, 23);
            txbNumero2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Número 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Resultado:";
            // 
            // txbResultado
            // 
            txbResultado.Location = new Point(78, 64);
            txbResultado.Name = "txbResultado";
            txbResultado.ReadOnly = true;
            txbResultado.Size = new Size(100, 23);
            txbResultado.TabIndex = 5;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(184, 34);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 6;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(184, 64);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 7;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(265, 34);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(265, 63);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 9;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 110);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(txbResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbNumero2);
            Controls.Add(txbNumero1);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "TreinaWeb Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbNumero1;
        private TextBox txbNumero2;
        private Label label2;
        private Label label3;
        private TextBox txbResultado;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}