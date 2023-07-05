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
            string string1 = "ABC";
            string string2 = "001";
            //concatecao pesada lenta
            //Console.WriteLine(string1 +" "+ string2+ " FDK ");
            // classe que faz operacao com strings
            StringBuilder sb = new StringBuilder();
            sb.Append(string1);
            sb.Append(" ");
            sb.Append(string2);
            sb.Append(" ");
            sb.Append("Fj5");
            Console.WriteLine("{0}", sb.ToString());
            Console.ReadKey();
        }
    }
  
}
