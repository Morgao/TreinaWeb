using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing
            int inteiro1 = 2;
            object objeto1 = inteiro1;
            // value type da stack para dentro da rip
            // Console.WriteLine("obect + {0}", objeto1);


            // unboxing
            int inteiro2 = (int)objeto1;
            Console.WriteLine("Inteiro 2 = {0}", inteiro2);
            Console.ReadKey();
        }
    }
  
}
