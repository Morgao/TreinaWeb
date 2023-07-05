using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //equanto
            int indice = 0;
            string[] versoes = new string[] { "1.0", "2.0", "5.0" };
            while (indice<versoes.Length) 
            {
                Console.WriteLine(versoes[indice]);
                indice++;

                // executa equanto a condicao e verdadeira
            }
            Console.ReadKey();
           
        }
    }
}
