using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            for (int i = 0; i <=9;i++) 
            {
                listaNumeros.Add(i);
                
            }
            listaNumeros.Remove(5);
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine("{0}", numero);
            }
           
            Console.ReadKey();
        }
    }
}
