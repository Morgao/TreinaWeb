using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> meuDicionario = new Dictionary<string, string>();
            meuDicionario.Add("Adicionar", "Adicionar significa somar");
            meuDicionario.Add("Subtrair", "Subitrair significa subitrair");
            foreach (string chave in meuDicionario.Keys)
            {
                Console.WriteLine(" {0} significa{1}", chave, meuDicionario[chave]);
            }
           
            Console.ReadKey();
        }
    }
}
