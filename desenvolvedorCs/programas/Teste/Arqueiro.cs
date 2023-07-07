using System;
namespace Personagens
{
    public class Arqueiro : Personagem
    {
        

        public Arqueiro(String nome, int vida) : base(nome, vida)
        {
           
       
        }
         public override void Atacar()
        {
            Console.WriteLine($"{ Nome } atacou com Arco e Flexa.");
        }

        public override void AtacarEspecial()
        {
            Console.WriteLine($"{ Nome } Atacou Especial com Arco e Flexa.");
        }
    }
}