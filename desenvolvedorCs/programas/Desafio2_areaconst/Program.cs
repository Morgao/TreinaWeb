using System;
namespace Azuleijo
{
    public class Program
    {
        public static void Main(string[] args)
        {
           double areaTotal = 0;
           double areaConstruida = 0;
           double total = 0;
           double nConstruida = 0;

           Console.WriteLine("Informe a area total do terreno:");
           areaTotal = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Informe a area total do construida:");
           areaConstruida = Convert.ToDouble(Console.ReadLine());
            nConstruida = areaTotal - areaConstruida;
           total = (nConstruida*3.80) + (areaConstruida*5.00);
           Console.WriteLine("O valor do imposto é de : {0}",total);

        }
    }
}