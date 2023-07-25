using System;
namespace Algoritmos 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numeros = new int[5];

            var nome5 = new string[5];

            var letras = new char[] { 'a', 'b', 'c', 'd' };

            Console.WriteLine(letras[0]);
            Console.WriteLine(letras[1]);
            Console.WriteLine(letras[2]);
            Console.WriteLine(letras[3]);

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

             Console.WriteLine(numeros[0]);
             Console.WriteLine(numeros[1]);
             Console.WriteLine(numeros[2]);
             Console.WriteLine(numeros[3]);
             Console.WriteLine(numeros[4]);

             foreach (var elemento in numeros)
             {
                Console.WriteLine(elemento);
             }

             for (int i = 0; i <letras.Length;i++)
             {
                Console.WriteLine(letras[i]);
             }

            
        }
    }

}