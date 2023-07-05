using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Teste teste1 // aponta pro ponteiro sem identificacao error
            Teste teste1 = new Teste();
            teste1.Quantidade = 17;
            teste1.testePai = new Teste();
            teste1.testePai.Quantidade = 6;
             
            Console.WriteLine("Valor do teste 1 {0}", teste1.Quantidade);
           
            //
            //Nao criou nenhum teste new do teste pai
            // null execption
            Console.WriteLine("Quantidade do tete pai {0}", teste1.testePai.Quantidade);
            

            Console.ReadKey();
        }
    }
    class Teste
    {
        public int Quantidade;
        public Teste testePai;
    }
}
