namespace ifelse
{
    public partial class frmIfElse : Form
    {
        public frmIfElse()
        {
            InitializeComponent();
        }

        private void btnVerificarIdade_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txbIdade.Text);
            if (idade >= 18) 
            {
                // se condicao verdadeira
                MessageBox.Show("Voc� � maior de idade!");
            }
            else 
            {
                // se for fala
                MessageBox.Show("Voc� � menor de idade!");
            }
        }
    }
}