using System;
using Contas;
using RH;
using Personagens;


namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cavaleiro = new Cavaleiro("Aragorn", 100);
            var arqueiro = new Arqueiro("Legolas", 100);
            var mago = new Mago("Gandalf", 100, 25);
            cavaleiro.Atacar();
            cavaleiro.AtacarEspecial();
            cavaleiro.Defender();

            arqueiro.Atacar();
            arqueiro.AtacarEspecial();
            arqueiro.Defender();
            
            mago.Atacar();
            mago.AtacarEspecial();
            mago.Defender();

           
            
            

           

        }
    }
}