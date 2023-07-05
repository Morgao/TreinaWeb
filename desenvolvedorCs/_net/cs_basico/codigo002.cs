using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero1 = 5;
            var nome = "Matheus";
            dynamic vari1 = 5;
            Console.WriteLine("variavel = {0}", vari1);
            vari1 = "escola";
            Console.WriteLine("valor 2 aghora  = {0}", vari1)
;
            
            Console.ReadKey();
        }
    }
 
}
