using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int[,] minhaMatriz = new int[2, 4];
            int numero = 0;
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    minhaMatriz[linha, coluna] = numero;
                    numero++;

                }

            }
            for(int linha = 0; linha < 2;linha++)
            {
                for(int coluna = 0;coluna < 4;coluna++)
                {
                    Console.WriteLine("minha matriz [{0}, {1}] = {2}", linha, coluna, minhaMatriz[linha, coluna]);
                }
            }
            // quantidade de dimensoes da matriz
            Console.WriteLine("Quantidade de   dimensoes {0}", minhaMatriz.Rank);
            Console.WriteLine("Quantidade de   tamanho {0}", minhaMatriz.Length);

            Console.ReadKey();


        }
    }
}
