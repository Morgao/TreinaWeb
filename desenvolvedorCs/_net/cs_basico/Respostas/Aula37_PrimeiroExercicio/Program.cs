using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula37_PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis que irão armazenar:
            // altura da parede (hp), a largura da parede (lp),
            // altura do azulejo (ha), largura do azulejo (la),
            // área da parede, área do azulejo e quantidade de azulejos
            double hp, lp, ha, la, areaParede, areaAzulejo, qtoAzulejos;

            try
            {
                //informando o usuário o valor que será obtido
                Console.WriteLine("Informe a altura da parede:");
                //obtendo a altura da parede
                hp = ObterValor();

                //informando o usuário o valor que será obtido
                Console.WriteLine("Informe a largura da parede:");
                //obtendo a largura da parede
                lp = ObterValor();

                //informando o usuário o valor que será obtido
                Console.WriteLine("Informe a altura do azulejo:");
                //obtendo a altura do azulejo
                ha = ObterValor();

                //informando o usuário o valor que será obtido
                Console.WriteLine("Informe a largura do azulejo:");
                //obtendo a largura do azulejo
                la = ObterValor();

                //calculando a área da parede
                areaParede = hp * lp;

                //calculando a área do azulejo
                areaAzulejo = ha * la;

                //calculando a quantidade de azulejos que serão necessários
                qtoAzulejos = areaParede / areaAzulejo;

                //informando o usuário resultado
                Console.WriteLine("\nA quantidade de azulejos necessários é {0}", qtoAzulejos);;
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
