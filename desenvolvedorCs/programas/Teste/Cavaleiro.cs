using System;
namespace Personagens 
{
    public class Cavaleiro : Personagem
    {
       

        public Cavaleiro(String nome, int vida) : base (nome, vida)
        {
           
            Id = "Cavaleiro1";
        }

        public override void Atacar()
        {
            Console.WriteLine($"{ Nome } atacou com espada.");
        }

         public override void AtacarEspecial()
        {
            Console.WriteLine($"{ Nome } Atacou Especial com Espada.");
        }

    }

}