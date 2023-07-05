using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Aluno 
    {
        public string Nome;
        public int Idade;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno();
            aluno1.Nome = "Joel";
            aluno1.Idade = 26;

            var aluno2 = new Aluno();
            aluno2.Nome = "Maria";
            aluno2.Idade = 28;
            Console.WriteLine(aluno1.Nome);
            Console.WriteLine(aluno1.Idade);
            Console.WriteLine(aluno2.Nome);
            Console.WriteLine(aluno2.Idade);
            Console.ReadKey();
            
        }
    }
}
