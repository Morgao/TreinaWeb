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
            if (3 > 4)
            {
                Console.WriteLine("E maior");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("E menor ou igual");
                Console.ReadKey();
            }
        }
    }
}
