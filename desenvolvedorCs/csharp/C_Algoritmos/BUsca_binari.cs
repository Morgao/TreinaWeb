using System;
namespace teste2
{
    internal class Program
    {   
      
        static void Main(string[] args)
        {
            var vetor = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            var buscado = 2;
            var inicio = 0;
            var fim = vetor.Length - 1;
            var indiceBuscado = -1;
            
            while(inicio <= fim)
            {
                var meio = (int)(inicio + fim) / 2;
                if (buscado == vetor[meio])
                {
                    indiceBuscado = meio;
                    break;
                }
                else if(buscado > vetor[meio])
                {
                    inicio = meio + 1;
                }
                else
                {
                    fim = meio - 1;
                }

            }
            if (indiceBuscado == -1)
            {
                Console.Write("Elemento não encontrado");
            }
            else
            {
                Console.Write($" O elemento de valor {buscado} encontra-se no indice {indiceBuscado}");
            }
           


                Console.ReadKey();
        }
    }
}