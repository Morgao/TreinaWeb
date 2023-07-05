private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);            
            txbResultado.Text = Somar(numero1, numero2).ToString();
        }

int Somar(params int[] numeros) 
        {
            int resultado = 0;
            foreach (int numero in numeros) 
            {
                resultado += numero;
            }
            return resultado;
        }