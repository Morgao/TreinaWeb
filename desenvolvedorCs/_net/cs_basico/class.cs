using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public class Carro
    {
        private string marca;
        public string Nome { get; set; }
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                if (value == "Fiat")
                {
                    marca = "Ford";
                }
                else
                {
                    marca = value;
                }
            }
        }
        public int NumeroPortas { get; set; }
        public double Potencia { get; set; }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Fiat";
            Console.WriteLine(carro.Marca);
            Console.ReadKey();
        }
    }
}
