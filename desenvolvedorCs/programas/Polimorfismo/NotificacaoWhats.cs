using System;
namespace Notificacoes
{
    public class NotificacaoWhats : Notificacao
    {
    public NotificacaoWhats(String destinatario, string mensagem) : base (destinatario, mensagem)
    {

    }

    public override void Enviar()
    {
        Console.WriteLine($"Enviando Whats para { Destinatario } com a mensagem { Mensagem}");
    }
    }
}