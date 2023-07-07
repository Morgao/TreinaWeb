using System;
using Notificacoes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de Notificação 1-email | 2- sms | 3- whatsaap");
            var tipo = Console.ReadLine();
            
            Console.WriteLine("Digite o Destinatario:");
            var destinatario = Console.ReadLine();

            Console.WriteLine("Digite a mensagem:");
            var mensagem = Console.ReadLine();

            Notificacao notificacao;

            switch(tipo)
            {
                case"1":
                notificacao = new NotificacaoEmail(destinatario, mensagem);
                break;
                case"2":
                notificacao = new NotificacaoSms(destinatario, mensagem);
                break;                
                case"3":
                notificacao = new NotificacaoWhats(destinatario, mensagem);
                break;
                default:
                notificacao = new NotificacaoEmail(destinatario, mensagem);
                break;

            }
            
            notificacao.Enviar();
        }

    }
}