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
            //equanto
            int indice = 10;
            var opcao =  "";
            
            do
            {
                Console.WriteLine("Digite uma Opcao:");
                Console.WriteLine("1 - Saque | 2 Deposito | 3 Saldo | 0 Sair");
                opcao = Console.ReadLine();
                switch (opcao) 
                {
                    case "1":
                        Console.WriteLine("Saque Realizado");
                        break;
                    case "2":
                        Console.WriteLine("Deposito Realizado");
                        break;
                    case "3":
                        Console.WriteLine("Saldo Disponivel");
                        break;



                }

                // executa equanto a condicao e verdadeira
            }
            while (opcao != "0");
            
                
            
          
           
        }
    }
}
