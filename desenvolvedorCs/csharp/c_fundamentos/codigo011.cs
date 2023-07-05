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
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaCorrente();
            conta1.Numero = "001-002";
            conta1.Saldo = 0;
            Console.WriteLine($"Numero: {conta1.Numero} | Saldo: {conta1.Saldo}");
            Console.ReadKey();

        }
    }
}
