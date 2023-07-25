using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7_SegundoExercicio
{
    class Program
    {
        delegate void Acao<T>(T[] array);
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //mostrando o array original
            Console.WriteLine("Lista origianal!");
            foreach (var item in array)
                Console.Write("{0}, ", item);

            //aplicando o delegate
            var del = new Acao<int>(DuplicandoElementos);
            del(array);

            Console.WriteLine("\n\n");

            //mostrado o array transformado pelo delegate
            Console.WriteLine("Lista transformada pelo delegate!");
            foreach (var item in array)
                Console.Write("{0}, ", item);

            Console.ReadKey();
        }

        public static void DuplicandoElementos(int[] array)
        {
            //duplicando os elementos do array
            for (int i = 0; i < array.Count(); i++)
                array[i] *= 2;
        }
    }
}
