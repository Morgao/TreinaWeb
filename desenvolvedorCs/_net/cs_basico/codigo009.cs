namespace OperadoresAritmeticos
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);
            int resultado = numero1 + numero2;
            txbResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);
            int resultado = numero1 - numero2;
            txbResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);
            int resultado = numero1 * numero2;
            txbResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);
            int resultado = numero1 / numero2;
            txbResultado.Text = resultado.ToString();
        }
    }
}