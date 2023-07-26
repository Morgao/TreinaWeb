using System;
namespace teste2
{
    internal class Program
    {   
        static int BuscarItem(int[] array, int itemBuscado)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
                if (array[i] == itemBuscado)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            // busca linear
            // busca dentro de um array
            // percorrer item a item, para achar o elemento
            // nao e o melhor algoritmo para listas ordenadas
            // melhor caso, o primeiro item é o buscado
            // pior caso, o ultimo é o item buscado

            var items = new int[] { 5, 10, 15, 20, 25 };

            var itemBuscado = 15;

          Console.WriteLine(BuscarItem(items, itemBuscado));


        }
    }
}