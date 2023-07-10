using System;
namespace Azuleijo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double hp = 0;
            double lp = 0;
            double x1 = 0;
            double ha = 0;
            double la = 0;
            double x2 = 0;
            double quantidade = 0;
            Console.WriteLine("Digite A Altura, largura da paredem, altura e largura do azuleijo: ");
            hp = Convert.ToDouble(Console.ReadLine());
            lp = Convert.ToDouble(Console.ReadLine());
            ha = Convert.ToDouble(Console.ReadLine());
            la = Convert.ToDouble(Console.ReadLine());

            x1 = hp * lp;
            x2 = ha * la;
            quantidade = x1/x2;
            Console.WriteLine("A quantidade de azuleijos é: {0}", quantidade);

        }
    }
}