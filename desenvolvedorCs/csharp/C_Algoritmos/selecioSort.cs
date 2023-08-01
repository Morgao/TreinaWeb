using System;
namespace Algoritmos 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vetor = new int []{4,1,5,3,2};

            for (int i = 0; i < vetor.Length;i++)
            {
                var menor = i;

                for(int j = i+1; j < vetor.Length;j++)
                {
                    if(vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }
                if(menor != i)
                {
                    var aux = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = aux;
                }
            }

           for (int i = 0; i < vetor.Length ; i++)
           {
            Console.Write($"{vetor[i]}");
           }

        }
    }

}