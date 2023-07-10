using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula37_SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis que irão armazenar:
            // a área total do terreno, a área construída do terreno, área não construída do terreno e o resultado
            double areaTotal, areaConstruida, areaNaoConstruida, resultado;

            //Constantes com os valores do imposto
            double IMPOSTO_AREA_CONSTRUIDA = 5;
            double IMPOSTO_AREA_NAO_CONSTRUIDA = 3.8;

            try
            {
                //informando o usuário o valor que será obtido
                Console.WriteLine("Informe a área total do terreno:");
                //obtendo a área total do terreno
                areaTotal = ObterValor();

                //informando o usuário o valor que será obtido
                Console.WriteLine("Informe a área total construída:");
                //obtendo a área total construída
                areaConstruida = ObterValor();

                //calculando a área não construída do terreno
                areaNaoConstruida = areaTotal - areaConstruida;

                //calculando o valor a ser pago
                resultado = (IMPOSTO_AREA_NAO_CONSTRUIDA * areaNaoConstruida) + (IMPOSTO_AREA_CONSTRUIDA * areaConstruida);

                //informando o usuário resultado
                Console.WriteLine("\nO valor a ser pago é {0}", resultado);
            }
            catch (Exception ex)
            {
                //Se ocorrer um erro, o usuário é informado.
                Console.WriteLine("\nOcorreu o erro: {0}", ex.Message);
            }

            Console.WriteLine("\nPressione qualquer tecla para finalizar a aplicação...");
            Console.ReadKey();
        }

        static double ObterValor()
        {
            try
            {
                //um valor é obtido no console
                var valor = Console.ReadLine();

                //o valor obtido é convertido para double antes de retorná-lo
                return Convert.ToDouble(valor);
            }
            catch (FormatException)
            {
                //caso ocorra um erro durante a conversão
                Console.WriteLine("\nValor informado erroneamente, o informe novamente:");//o \n pula uma linha

                //O valor é obtido novamente
                return ObterValor();
            }
            catch (Exception ex)
            {
                //caso ocorre outro tipo de erro
                // ele é retornado para o método chamador
                throw ex;
            }
        }
    }
}
