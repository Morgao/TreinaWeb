public delegate void EscreverMensagem();
public void Mensagem1()
{
    Console.WriteLine("Mensagem 1");
}

public void Mensagem2()
{
    Console.WriteLine("Mensagem 2");
}

public void Mensagem3()
{
    Console.WriteLine("Mensagem 3");
}
EscreverMensagem mensagemDelegate = new EscreverMensagem(Mensagem1);
mensagemDelegate += Mensagem2;
mensagemDelegate += Mensagem3;
mensagemDelegate();