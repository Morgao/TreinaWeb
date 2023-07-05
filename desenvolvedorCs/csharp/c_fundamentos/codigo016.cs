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
                var nomes = new[] { "Arkinda", "maria", "joana" };
                for (var i = 0; i <= nomes.Length; i++)
                    {
                    Console.Write(nomes[i]);
                    }
            }
            catch(Exception exceccao) 
            {
                Console.WriteLine("Ocorreu um erro: " + exceccao.StackTrace); ;
            }
            Console.ReadKey();
        }
    }
}
