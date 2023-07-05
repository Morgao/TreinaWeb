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
            var numero = new[] { 2, 5, 734, 341, 312 };
            for(int i = 0; i < 5; i++) 
            {
                Console.WriteLine(numero[i]);
            }

            Console.ReadKey();
          
           
        }
    }
}
