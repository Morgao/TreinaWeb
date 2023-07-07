using System;
namespace Personagens
{
    public class Mago : Personagem
    {
        public int Magia { get; set; }

        public Mago(String nome, int vida, int magia) : base(nome, vida)
        {
           
            Magia = magia;
        }
         public override void Atacar()
        {
            Console.WriteLine($"{ Nome } atacou com Magia.");
        }

         public override void AtacarEspecial()
        {
            Console.WriteLine($"{ Nome } Atacou Especial com Magia.");
        }
    }
}