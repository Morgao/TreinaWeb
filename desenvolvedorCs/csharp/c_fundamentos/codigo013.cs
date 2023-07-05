using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ContaCorrente 
    {
        public string Numero;
        public decimal Saldo;

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Numero: {Numero} | Saldo: {Saldo}");
        }

        public string ListarInformacoes() 
        {
            return $"NUMERO: {Numero} | SALDO: {Saldo}";
        }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaCorrente();
            conta1.Numero = "001-002";
            conta1.Saldo = 0;
            Console.WriteLine(conta1.ListarInformacoes());
            
            Console.ReadKey();

        }
    }
}
