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
            Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
            meuDicionario.Add(1, "Numero baixo");
            meuDicionario.Add(5, "Numero medio");
            meuDicionario.Add(8, "numero Alto");
            foreach (int chave in meuDicionario.Keys)
            {
                Console.WriteLine(" {0} significa{1}", chave, meuDicionario[chave]);
            }
           
            Console.ReadKey();
        }
    }
}
