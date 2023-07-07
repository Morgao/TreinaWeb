using System;
namespace Notificacoes
{
    public class NotificacaoSms : Notificacao
    {
    public NotificacaoSms(String destinatario, string mensagem) : base (destinatario, mensagem)
    {

    }

    public override void Enviar()
    {
        Console.WriteLine($"Enviando SMS para { Destinatario } com a mensagem { Mensagem}");
    }
    }
}