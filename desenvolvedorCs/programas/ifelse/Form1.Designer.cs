namespace ifelse
{
    partial class frmIfElse
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
            txbIdade = new TextBox();
            btnVerificarIdade = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite a Idade Desejada:";
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(150, 9);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(110, 23);
            txbIdade.TabIndex = 1;
            // 
            // btnVerificarIdade
            // 
            btnVerificarIdade.Location = new Point(266, 9);
            btnVerificarIdade.Name = "btnVerificarIdade";
            btnVerificarIdade.Size = new Size(75, 23);
            btnVerificarIdade.TabIndex = 2;
            btnVerificarIdade.Text = "Verificar";
            btnVerificarIdade.UseVisualStyleBackColor = true;
            btnVerificarIdade.Click += btnVerificarIdade_Click;
            // 
            // frmIfElse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 68);
            Controls.Add(btnVerificarIdade);
            Controls.Add(txbIdade);
            Controls.Add(label1);
            Name = "frmIfElse";
            Text = "TreinaWeb IF/ELSE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbIdade;
        private Button btnVerificarIdade;
    }
}