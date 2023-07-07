Atributos ou propriedades da Classe

Através dos atributos de uma classe, nós podemos alterar e recuperar valores de variáveis relacionados à ela. Eles são divididos em dois tipos:

    Campos: Campos são simplesmente variáveis, visíveis a partir das instâncias da classe. São variáveis públicas;
    Propriedades: Propriedades são mais sofisticadas, podendo ter um bloco get (utilizado para ler um valor) e um bloco set (utilizado para atribuir um valor). Estes blocos são utilizados para atribuir valores para uma variável privada, mantendo o princípio de encapsulamento que veremos adiante.

Atributos tipo “campo”

Atributos do tipo campo são variáveis públicas. Os atributos são inicializados durante a criação do seu objeto com os valores dependendo o seu tipo:

    Numéricos como 0
    Strings como null
    Booleanos como false
    Objetos como null


Abaixo nós temos a classe Cliente como exemplo de atributos do tipo campo:
class Cliente
{
      public int codigo;
      public string nome;
      public bool ativo;
}
Os atributos também podem receber um valor padrão, definido na sua declaração: 

class Cliente
{
      public int codigo = 1;
      public string nome = "Carlos Silva";
      public bool ativo = true;
}
Propriedades da classe

Veja abaixo dois exemplos de atributos. Primeiro do tipo campo, que acabamos de ver:

class Cliente
{
      public int codigo;
}J
á o atributo tipo propriedade, ao contrário de um campo, é um atributo mais sofisticado. Por exemplo:
class Cliente
{
      private int codigo;

      public int Codigo
      {
            get { return codigo; }
            set { codigo = value; }
      }
}



A variável privada está escrita no padrão camelCase. Já o nome da propriedade é escrito no padrão PascalCase.

Por exemplo: para criar uma propriedade chamada NomeCliente, teríamos uma variável privada chamada nomeCliente. O padrão camelCase significa que o nome do identificador deve começar em minúscula e a primeira letra de cada palavra concatenada em maiúscula. O padrão PascalCase significa que o nome do identificador deve começar em maiúscula e a primeira letra de cada palavra concatenada em maiúscula.

As principais vantagens em utilizar propriedades são:

    Padrão amplamente utilizado no C#;
    Permite validar os valores que estão entrando e saindo da classe;
    Isola o ambiente externo do ambiente interno da classe (encapsulamento);
    Podemos definir se haverá apenas get, set ou ambos.

Abaixo temos o código completo da classe Cliente com os atributos do tipo propriedades:

class Cliente
{
      private int codigo;
      private string nome;
      private bool ativo;

      public int Codigo
      {
            get { return codigo; }
            set { codigo = value; }
      }

      public string Nome
      {
            get { return nome; }
            set { nome = value; }
      }

      public bool Ativo
      {
            get { return ativo; }
            set { ativo = value; }
      }
}