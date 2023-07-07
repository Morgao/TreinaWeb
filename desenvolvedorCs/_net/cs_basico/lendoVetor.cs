using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOOBonagouro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            int maior = 0;
            for (int i = 0; i < 5; i++)
            {
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
        }
    }
}
