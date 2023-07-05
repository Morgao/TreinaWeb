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

 MessageBox.Show("") sair mensagem no windows forms


namespace DebugTeste
{
    internal class Program
    {
        int LerInteiro()
        {
            Console.WriteLine("Digite um número: ");
            return int.Parse(Console.ReadLine());
        }

        int SomarNumeros(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        void ExecutarPrograma()
        {
            int numero1 = LerInteiro();
            int numero2 = LerInteiro();
            int soma = SomarNumeros(numero1, numero2);
            Console.WriteLine("O resultado da soma é: {0}", soma);
        }
        static void Main(string[] args)
        {
            (new Program()).ExecutarPrograma();
        }
    }
}