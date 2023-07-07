using System;
namespace Itens
{
    public class Joia : Item, IColecionavel, IConsumivel
    {
        public int Valor { get; set; }

        public Joia(string nome, int x, int y, int valor) : base(nome,x,y)
        {
            Valor = valor;
        }

        public void Colecionar()
        {
            Console.WriteLine("Joia Colecionada.");
        }

        public void Consumir()
        {
            Console.WriteLine("Joia Consumida");
        }
    }
}