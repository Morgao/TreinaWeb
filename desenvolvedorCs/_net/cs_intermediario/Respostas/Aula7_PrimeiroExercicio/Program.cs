using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7_PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            //Testando o método com lista de inteiros
            var listaInteiro = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var minInteiro = 4;

            var result = ContaMaiores(listaInteiro, minInteiro);
            Console.WriteLine("Resultado na lista de inteiros: {0}", result);


            //Testando o método com lista de valores em formato texto.
            var listaEmTexto = new List<string>() { "1", "2", "3", "4", "5", "6" };
            var minEmTexto = "4";

            result = ContaMaiores(listaEmTexto, minEmTexto);
            Console.WriteLine("Resultado na lista em formato texto: {0}", result);

            //Testando o método com valores facionários
            var listaPontoFlutuante = new List<float>() { 1.2F, 2.4F, 3.6F, 4.8F, 5.0F, 6.2F };
            var minPontoFlutuante = 4F;

            result = ContaMaiores(listaPontoFlutuante, minPontoFlutuante);
            Console.WriteLine("Resultado na lista facionária: {0}", result);

            Console.ReadKey();
        }

        private static int ContaMaiores<T>(List<T> lista, T min)
        {
            //contará a quantidade de elementos maiores que min na lista
            int count = 0;
            try
            {
                //Percorrendo a lista
                foreach (var item in lista)
                {
                    //Como o tipo dos elementos é genérico, todos são convertidos para double para realizar a comparação
                    double elemento = (double)Convert.ChangeType(item, typeof(double));
                    double minimo = (double)Convert.ChangeType(min, typeof(double));

                    //comparando
                    if (elemento > minimo)
                        count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu o erro {0}", ex.Message);
            }
            return count;
        }
    }
}
