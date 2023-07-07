using System;
namespace Contas
{
    public class Conta
    {
        public static double taxaRendimento = 0.5f;
        public string Numero;
        public DateTime DateAbertura;
        public decimal Saldo;

        public Conta()
        {
            Numero = DateTime.Now.ToString("yyyyMMddhhmmss");
            DateAbertura = DateTime.Now;
            Saldo = 0;          
           
        }

        public Conta(string numero, DateTime dateAbertura, decimal saldo)
        {
            Numero = numero;
            DateAbertura = dateAbertura;
            Saldo = saldo;
        


        }
        public string ExibirExtrato()
        {
            //Console.WriteLine($"Conta N:           {Numero}");
           // Console.WriteLine($"Data de Abertura:  {DateAbertura.ToString("dd/MM/yyyy")}");
            //Console.WriteLine($"Saldo:             {Saldo.ToString("C")}");
            //Console.WriteLine("--------------------");
            return $"Conta N:           {Numero}{Environment.NewLine}"+
            $"Data de Abertura:  {DateAbertura.ToString("dd/MM/yyyy")}{Environment.NewLine}"+
            $"Saldo:             {Saldo.ToString("C")}{Environment.NewLine}"+
            "--------------------";
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"O valor { valor } foi creditado e será debitado dentro de 30 dias.");
        }

        public void RealizarEmprestimo(decimal valor, int parcelas)
        {
            Saldo += valor;
            Console.WriteLine($"O valor { valor } foi creditado e será debitado em {parcelas} vezes.");

        }

        public static double CalcularRendimento(double capital, int meses)
        {
            return capital * Math.Pow(1+taxaRendimento, meses);
        }



    }
}