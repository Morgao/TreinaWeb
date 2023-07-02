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
            Console.WriteLine("Qual seu nome ?");
            var nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
            Console.ReadKey();
        }
    }
}
