Métodos

Método é uma sequência nomeada de instruções. Cada método tem um nome e um corpo. O corpo contém as instruções que serão executadas quando o método for chamado. O nome do método deve ajudar a identificar seu propósito, ex: CalcularImpostoVenda.

A maioria dos métodos recebe dados, processa-os e retorna a informação – ou o resultado do processamento. Método é um mecanismo fundamental e poderoso. Veja a sintaxe de declaração de um método:

[Modificadores] tipoDeRetorno NomeDoMetodo ( listaDeParamentros opcional )
{
// corpo do método
}



Onde:

    Modificadores: os modificadores de acesso são utilizados para restringir o acesso aos métodos (serão tratados no tópico de classes);
    tipoDeRetorno: é o tipo de dado que será retornado pelo método após a execução. Pode ser o nome de qualquer tipo como int ou string. Se o método não for retornar valor algum, você precisa usar a palavra reservada void, especificando que o método não retorna nada;
    NomeDoMetodo: é o nome que será usado para chamar o método. Ele deve seguir as mesmas recomendações usadas nos nomes das variáveis, só que no caso do método, procure usar a notação Pascal Case para nomear os métodos e também procure utilizar um verbo na primeira palavra do nome para ajudar a identificar o que o método faz;
    ListaDeParametros: descreve o tipo e os nomes das informações opcionais que o método recebe. Os parâmetros devem ser escritos dentro dos parênteses, como se fosse declarar variáveis: nome do tipo seguido pelo nome do parâmetro. Se o método tiver mais de um parâmetro, separe-os com vírgula;
    Corpo do método: linhas de código que serão executadas quando o método for chamado.

A seguir um exemplo do método chamado AdicionarValores, que retorna um número inteiro (int) e recebe dois números inteiros como parâmetros:


int AdicionarValores (int numeroPequeno, int numeroGrande)
{
      //...
      // corpo do método deve ser feito aqui
      //...
}

Veja outro exemplo: o método chamado MostrarResultado, que não retorna valor algum e recebe um simples parâmetro chamado pergunta do tipo int. 

void MostrarResultado (int pergunta)
{
      // ...
}

 Lembre-se de usar a palavra reservada void quando o método não retornar nada.

Escrevendo métodos que retornam valores

Se você quer que o método retorne uma informação (em outras palavras, que retorne um tipo e não um void), você precisa escrever um código de retorno dentro do método. Para isso, use a palavra reservada return, seguida da expressão que calcula o valor a ser retornado.
Dica

O resultado da expressão deve ser do mesmo tipo que o especificado como tipoDeRetorno do método, senão o programa não irá compilar.

Por exemplo: 

int AdicionarValores (int numeroPequeno, int numeroGrande)
{
      //...
      return numeroPequeno + numeroGrande;
}



Lembre-se do ponto-e-vírgula (;) ao final de cada instrução.

O retorno do método deve estar no final do método porque ele causa a sua finalização. Qualquer código depois da linha que faz o retorno não será executado.

Se você não quer que o método retorne informação alguma (do tipo void) pode usar a variação da palavra reservada return para causar o encerramento imediato do método. Digite return seguido de ponto-e-vírgula (;).

Por exemplo:


void MostrarResultado (int pergunta)
{
      ...
      if (...)
            return;
      ...
}

Se o método não precisar retornar nada, pode simplesmente omitir o return porque o método será finalizado automaticamente quando a última linha de código do corpo for executada. 

Especificando a sintaxe para se chamar um método

Para chamar um método, usamos a sintaxe abaixo:


NomeDoMetodo (listaDeArgumentos opcional)



Onde:

    NomeDoMetodo: precisa ser exatamente igual ao nome do método que você está chamando, lembre-se que C# é case-sensitive, ou seja: diferencia letras maiúsculas de minúsculas.
    listaDeArgumentos: informações adicionais que o método aceita; é preciso passar um valor para cada parâmetro, sendo que este valor deve ser compatível com o tipo correspondente ao parâmetro. Se o método que você está chamando tiver dois ou mais parâmetros, será preciso separar os valores com vírgula.

Dica

Você precisa escrever os parênteses ao final de cada método, mesmo que não tenha parâmetro algum. Isso indica ao compilador que aquilo se trata da chamada de um método, não de uma propriedade ou atributo (itens que veremos adiante).

Por exemplo, reveja o método AdicionarValores:

int AdicionarValores (int numeroPequeno, int numeroGrande)
{
      //...
      return numeroPequeno + numeroGrande;
}

Este método tem dois parâmetros entre os parênteses. Para chamá-lo, faça assim: 

AdicionarValores(39, 3)



Esta é a maneira correta de chamar o método. Se você tentar, em uma das seguintes formas, não conseguirá:


AdicionarValores // Falta parênteses
AdicionarValores() // Falta argumentos
AdicionarValores(39) // Falta um argumento
AdicionarValores("39", "3") // Tipos errados



O método AdicionarValores retorna um número inteiro. Este valor inteiro pode ser usado em qualquer lugar em que uma variável int puder ser usada.

Por exemplo:


resultado = AdicionarValores(39,3);
MostrarResultado(AdicionarValores(39,3));



No primeiro exemplo, o retorno foi atribuído a uma variável chamada resultado.

No segundo, o resultado foi atribuído a outro método, que utilizará o resultado como parâmetro para sua execução.
