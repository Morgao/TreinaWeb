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
            try
            {
                var soma = Convert.ToDecimal(Console.ReadLine());
                var quantidade = Convert.ToDecimal(Console.ReadLine());
                var media = soma / quantidade;
                Console.WriteLine("Média calculada: " + media);
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não é um número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor digitado excede os limites suportados.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            Console.ReadKey();
        }
    }
}
