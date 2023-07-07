Introdução à Orientação a Objetos em C#

A Orientação a Objeto (OO) é uma série de conceitos aplicados à linguagem de programação que ajuda a definir a estrutura de programas baseando-se nos conceitos do mundo real, sejam eles reais ou abstratos. Ela permite criar programas, que separam as partes do sistema por responsabilidades e fazendo com que essas partes se comuniquem entre si, por meio de mensagens.

Por exemplo: uma parte da equipe poderia criar as classes contendo as regras de negócios e outra parte poderia criar as telas gráficas, seja para desktop ou para a web.

Dentre as vantagens que a OO proporciona, podemos destacar o aumento de produtividade, reutilização de código, redução das linhas de código programadas, separação de responsabilidades, encapsulamento, polimorfismo, componentização e maior flexibilidade do sistema, dentre outras vantagens.
Definição de classes

Uma classe nada mais é do que a definição do que será um objeto. As classes definem a estrutura e o comportamento dos objetos daquele determinado tipo. Podemos dizer que as classes são, na verdade, modelos de objetos do mesmo tipo. Abaixo temos uma representação gráfica da classe:

A partir desta classe Carro, podemos criar vários objetos do tipo Carro. É como se a classe fosse a forma para fabricar objetos com a estrutura que ela define.

Para facilitar a assimilação inicial do conceito de uma classe você pode fazer uma analogia em relação à construção de uma casa. Para construir uma casa você deve ter o projeto da casa. No projeto constam todas as especificações de como a casa será construída. A partir deste projeto, se você quiser você poderia construir várias casas.

Para criar a classe acima no C#, seguimos a seguinte sintaxe:

[modificador] class nome_classe [:classe_base]{

      //Atributos
       [modificador] tipo nome;

      //Métodos
       [modificador] tipo nome_metodo
      {
      }
}
A classe Carro, por exemplo, ficaria com o seguinte código: 
class Carro
{
      public string Cor = "";
      public string Modelo = "";
      public string Motor = "";
      public string Status = "";

      public void Ligar()
      {
            Status = "Ligando o carro.";
      }

      public void Desligar()
      {
            Status = "Desligando o carro.";
      }

      public void Acelerar()
      {
            Status = "Acelerando o carro.";
      }

      public void Brecar()
      {
            Status = "Brecando o carro.";
      }

      public void MudarMarcha()
      {
            Status = "Mudando de Marcha.";
      }
}



As variáveis Cor, Modelo, Motor e Status são os atributos da classe. Em seguida, temos os métodos: Ligar, Desligar, Acelerar, Brecar e MudarMarcha. Mais à frente, veremos maiores detalhes sobre atributos e métodos das classes.

Repare nos seguintes pontos:

    Para classes públicas, recomendamos que cada classe seja criada em um arquivo e que o nome do arquivo seja idêntico ao nome da classe, apesar de o C# não obrigar que o nome do arquivo tenha o mesmo nome da classe;
    Observe que esta classe não tem o método Main, ou seja, ela não poderá ser executada diretamente;
    Se esta classe não possui o método Main, ela será utilizada a partir de outra classe.



bjetos

Um objeto nada mais é do que uma instância de classe. É uma estrutura que é criada com as mesmas especificações da classe que o originou. O objeto criado fica armazenado na memória, permitindo assim a utilização de seus atributos e métodos. Eles possuem:

    Estado (atributos);
    Comportamento (métodos);
    Identidade (cada objeto é único).

Os objetos se comunicam entre si por meio de mensagens, que são chamadas aos métodos de nosso objeto. No C#, todo método deve ser criado dentro de uma classe.

Os métodos ainda podem ser de dois tipos: um procedimento, que é um bloco de instruções que não retorna valor (void); e uma função, é um método que retorna um valor.

Para criarmos instâncias de classes (ou seja, objetos) a partir da classe Carro, o código ficaria da seguinte maneira:


Carro c1 = new Carro();
Carro c2 = new Carro();
A partir de uma classe podemos criar vários objetos. No exemplo acima c1 e c2 são objetos. Poderíamos desmembrar a instrução acima em duas partes: 

Carro c1; //Declaração da variável c1 do tipo Carro
c1 = new Carro(); //Instanciando a classe



Ou seja, c1 é uma variável de objeto que representa uma instancia da classe, um objeto do tipo Carros. A partir de c1 e c2 teremos acesso aos atributos e métodos da classe Carros.

Repare que, para criar um objeto a partir de uma classe, devemos utilizar a keyword new. Esta keyword é responsável por informar que deve ser criado um novo objeto e este deve ser armazenado em uma nova posição de memória.

tilizando a classe Carro

Após instanciar a classe, temos acesso aos métodos e atributos da classe:

Exemplo utilizando a classe Carro:

Carro c1 = new Carro();
c1.Cor = "Vermelho";
c1.Modelo = "Vectra";
c1.Motor = "1.8";
c1.Ligar();
c1.Acelerar();
c1.MudarMarcha();
c1.Brecar();
c1.Desligar();
Onde criamos uma instancia da classe Carro: 

Carro c1 = new Carro();


Configuramos alguns atributos:

c1.Cor = "Vermelho";
c1.Modelo = "Vectra";
c1.Motor = "1.8";
c1.Ligar();
c1.Acelerar();
c1.MudarMarcha();
c1.Brecar();
c1.Desligar();