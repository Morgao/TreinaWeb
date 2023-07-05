Controle de fluxo, expressões e operadores condicionais

Quando estivermos desenvolvendo uma aplicação, serão comuns os momentos onde nosso software deverá verificar se uma determinada situação está ocorrendo ou não. Por exemplo, pode ser que nosso software precise verificar se o número que o usuário digitou é maior que zero ou não. Se for, nosso código executará um determinado conjunto de procedimentos. Se não, deverá executar um outro conjunto de instruções diferentes.

Para verificarmos este tipo de situação, nós precisaremos das estruturas condicionais. Vamos ver agora quais são as estruturas condicionais do C# e como utilizá-las.

Estruturas condicionais e condições lógicas

Em nossas aplicações, por vezes, é necessário avaliar se determinadas condições são verdadeiras ou não. Por exemplo: podemos precisar verificar se, entre dois números digitados pelo usuário, o primeiro é maior que o segundo. Para este tipo de verificação, nós temos as estruturas condicionais. Com elas, você pode verificar se uma determinada expressão lógica (em nosso exemplo, primeiro número digitado é maior que o segundo) é verdadeira ou não. Caso seja, você pode executar um determinado trecho de código, caso não, você pode executar outro trecho de código ou não executar nenhum código.

Antes de estudar os operadores condicionais, você deve primeiro entender o que é uma expressão condicional. Esta é uma expressão que sempre retorna um valor booleano, ou seja: verdadeiro ou falso. Por exemplo:

Preço é menor que 100.

Se preço for menor que 100 então o resultado da expressão acima é VERDADEIRO. Caso contrário, o resultado é FALSO.

Você pode usar os seguintes operadores para fazer comparações em C#: 
==
!=
>
<
>=
<=

O condicional if

O if avalia uma expressão lógica booleana. Caso você especifique algo que não seja uma expressão booleana lógica, o compilador irá acusar um erro. Se o resultado for verdadeiro, o bloco de código dentro do if será executado. Caso contrário, o controle é passado para a próxima declaração após o if. Os projetistas de C# optaram por aceitar unicamente expressões booleanas no if para evitar escrever código com semântica obscura e propensa a resultados inesperados.

A declaração if tem três formas básicas:

1.


if (expressão)
{
      // Declaração
}
2.

if (expressão)
{
      // Declaração
}
[else
{
      // Declaração
}
]
3.
if (expressão)
{
      // Declaração
}
[else if (expressão)
{
      // Declaração
}




Veja alguns exemplos:

int a = 0;
int b = 1;
if ( a < b )
{
      Console.WriteLine("B é maior");
}
else
{
      Console.WriteLine("A é maior");
}



O exemplo anterior é sintaticamente correto, mas o que aconteceria se a=b? O código passaria a dar a resposta incorreta porque ele não avalia a condição a=b, o que torna o código inconsistente. Reescreva-o de forma que a condição de igualdade seja avaliada:


int a = 0;
int b = 0;

if ( a < b )
{
      Console.WriteLine("B é maior");
}
else if ( a > b )
{
      Console.WriteLine("A é maior");
}
else
// E finalmente a condição de igualdade deveria ser satisfeita
{
      Console.WriteLine("A é igual a B");
}

No exemplo a seguir tente avaliar uma expressão inteira: 

public int compString(string a, string b)
{
      // Implementação do método
      if (a == b)
      {
            return 0;
      }
      else
      {
            return -1;
      }
}

Chamando o método: 

if (compString(str1,str2)) // Uso ilegal!
{
      Console.WriteLine("Strings iguais");
}
else
{
      Console.WriteLine("Strings diferentes");
}

O uso do if acima é ilegal, pois o compilador não consegue converter um tipo inteiro para booleano. Esse tipo de erro poderia ser cometido por um programador acostumado a avaliar expressões numéricas dentro de um if. Reescrevendo o código acima, você terá o seguinte: 

if (compString(str1,str2) == 0) // Uso correto!
{
      Console.WriteLine("Strings iguais");
}
else
{
      Console.WriteLine("Strings diferentes");
}

Não se esqueça que o sinal de comparação em C# são os “dois iguais” (==). Um único igual no C# significa atribuição, quando você, por exemplo, atribui um valor a uma variável.

Else-if

É possível avaliar diversos else ifs com uma determinada expressão. Como neste exemplo:


double salario = 1200;
if(salario < 500)
      salario += 50;
else if((salario >= 500) &&(salario < 600))
      salario += 100;
else if((salario >= 500) &&(salario < 700))
      salario+= 110;
else
      salario += 250;

erceba que no bloco de código acima foi usado o &&. O && é usado quando se precisa testar mais de uma expressão condicional. Exemplo:

else if ((salario >= 500) && (salario < 600))

Nessa linha é verificado se o salário é maior ou igual a 500 E se salário é menor que 600. Então se o salário for 553 a expressão acima é VERDADEIRA, caso contrário é FALSA.

O && é conhecido como um operador lógico. Eles são três, como mostra a tabela a seguir: 

Operador lógico
	

Significado

&& (and)
	

Se duas expressões condicionais forem verdadeiras, o resultado é verdadeiro

|| (or)
	

Se qualquer expressão condicional é verdadeira, o resultado é verdadeiro

! (not)
	

Se a expressão condicional for falsa, o resultado é verdadeiro. Se a expressão condicional for verdadeira, o resultado é falso

Algumas expressões complexas podem exigir mais de um operador lógico. A sequência de execução nesse tipo de expressão é: primeiro os operadores matemáticos, depois os operadores de comparação, e só então os operadores lógicos.

Veja alguns exemplos da utilização dos operadores lógicos:

Expressão
	

Resultado

Cargo == “Gerente” && Salario > 10000
	

Verdadeiro se as duas condições forem verdadeiras

Cargo == “Ajudante” || Salario < 700
	

Verdadeiro se uma das condições for verdadeira

!Salario < 500
	

Verdadeira, se a condição for falsa

O condicional switch

A declaração switch avalia uma expressão cujo resultado pode ser dos tipos sbyte, byte, short, ushort, int, uint, long, ulong, char, string ou enum e este, por sua vez, é comparado a cada uma das seções case que constituem o switch. Veja a sua sintaxe:

switch(expressão)
{
      case constante1:
            declaração 1;
            break;

      case constante2:
            declaração 2;
            break;
      // Mais expressões case

      [default:
            declarações;
            break;
      ]
}



Antes de apresentar um exemplo, cabe destacar três aspectos importantes sobre o condicional switch:

    Em C# , cada seção case deve conter uma declaração break;
    A seção default, que é avaliada caso nenhuma das seções case seja verdadeira, não é obrigatória.
    Não pode existir mais de uma seção case com a mesma constante. Veja o exemplo a seguir:


switch(compInt(10,20))
{
      case 0:
            Console.WriteLine("A é igual a B");
            break;
      case -1:
            Console.WriteLine("A é menor do que B");
            break;
      case -1: // Duplicado!
            Console.WriteLine("A é maior do que B");
            break;
}



O compilador acusará erro porque a constante -1 já foi definida na seção case anterior.

Agora veja alguns exemplos do uso do switch, mas primeiramente veja que o método compInt foi alterado para o código abaixo:

public static int compInt(int num1, int num2)
{
      if (num1 == num2)
      {
            return 0;
      }
      else if(num1 < num2)
      {
            return -1;
      }
      else
      {
            return 1; // num1 > num2
      }
}

Chamando o método acima, usando o switch. Note que será verificado em qual situação a expressão compInt(10,20) vai se encaixar: se 10 é igual a 20, se 10 é maior que 20 ou se 10 é menor que 20 (essa última situação só ocorrerá se 10 não for nem igual a 20 e nem maior, por estar dentro do bloco default): 

switch(compInt(10,20))
{
      case 0:
            Console.WriteLine("A é igual a B");
            break;
      case 1:
            Console.WriteLine("A é maior do que B");
            break;
      default:
            Console.WriteLine("A é menor do que B");
            break;
}

Quando quiser que várias seções case executem o mesmo bloco de declarações, elas podem ser combinadas da seguinte forma: 

switch(compInt(10,20))
{
      case 0:
            Console.WriteLine("A é igual a B");
            break;
      // Combinando seções case
      case 1: // A é maior do que B
      default: // A é menor do que B
            Console.WriteLine("A é diferente de B");
            break;
}

A seção case, cuja constante é 1, quando satisfeita executará as declarações da seção default. Mais seções case poderiam ser acrescentadas e o resultado seria sempre a execução da seção default. 

Laços ou estruturas de repetição

As estruturas de repetição – também conhecidas como estruturas de looping ou laços– permitem executar uma linha ou bloco de código repetidamente, até que uma condição seja verdadeira.

O uso de loopings nos programas é uma prática comum, pois, em muitos casos é preciso percorrer uma determinada coleção de dados, um conjunto de registros, valores de matrizes, etc.

A linguagem C# dá suporte a quatro tipos diferentes de laços:

    For
    Foreach/in
    While
    Do/while


O laço for

O laço for é usado quando se sabe o número de vezes que o loop será executado. O laço em C# segue o mesmo estilo das linguagens C/C++, e a sua sintaxe tem as seguintes características:

    Uma variável de inicialização pode ser declarada dentro do for;
    Uma condição avalia uma expressão para abandonar o for ou executá-lo novamente;
    Uma expressão incrementa o valor da variável de inicialização.

A sintaxe do for é a seguinte:

for (inicialização; condição; incremento ou decremento){
      // Seu código que será repetido
}


Por exemplo, verifique o trecho de código abaixo:

for (int i = 0; i <=3; i++)
{
      Console.WriteLine("Isso é um teste do laço for");
}
A mensagem “Isto é um teste do laço for” será exibida 4 vezes. Isso ocorre porque você a colocou dentro do for. O for acima tem uma variável (int i = 0) que vai controlar a quantidade de vezes que a expressão será executada. A segunda parte (i <=3) nos mostra que o código dentro do for será executado enquanto a variável i for menor ou igual a 3. A última parte (i++) nos mostra que, a cada vez que o for for executado, a variável i será incrementada em 1. Dessa maneira, nosso código será executado 4 vezes: enquanto a variável i for de 0 até 3. Na quinta interação, a variável i vai assumir o valor 4 e a verificação especificada na segunda parte do for (i <=3) se tornará inválida, o que fará com que o código dentro do for não seja mais executado.

Break

Para abandonar um laço antes que a condição for seja falsa, usa-se a palavra reservada break. Por exemplo:


for(int i = 0; i <= 5; i++)
{
      Console.WriteLine ("Iteração número {0}", i);
      if (i == 3)
            break;
}

A utilização do break no exemplo acima fará com que todo o trecho de código dentro do laço for seja executado somente 4 vezes, pois, quando a variável i assumir o valor 3 (ou seja, na quarta vez que o código for executado), a palavra break fará com que o for seja “cancelado”.: 

Continue

A palavra reservada continue permite que o fluxo de execução da iteração corrente seja abandonado, mas não o laço, e a iteração seguinte dê início no topo do laço, uma vez que a condição do for seja satisfeita.

Exemplo:

for(int i = 0; i <= 5; i++)
{
      Console.WriteLine("Iteração número {0}", i);
      if (i == 3)
            continue;
      /* A declaração a seguir não será executada quando i==3, porém, o for será "chamado" novamente, incrementando o valor de i */
      Console.WriteLine ("Iteração número {0}", i +2);
}



Laços infinitos

Veja no exemplo a seguir uma forma de usar laços for para implementar iterações infinitas:

StringBuilder strB= new StringBuilder(" ");
Console.WriteLine( "Digite múltiplas linhas separadas por enter. Para sair digite \"sair\" ");
for (;;)
{
      string linha = Console.ReadLine( );
      if ((linha.ToUpper( ) == "SAIR" ))
            break;
      else
            strB.Append(linha);
}

Laços aninhados

Laços aninhados são laços dentro de laços que podem ser usados, por exemplo, para varrer arrays multidimensionais (que veremos a frente).

Exemplo:

int[,] multInt = new int[2,2] {{1,2},{3,4}};
for (int i = 0; i < multInt.GetLength(0); i++)
{
      for (int j = 0; j < multInt.GetLength(1); j++)
      {
            Console.Write("{0}\t", multInt[i,j]) ;
      }
}



Se uma declaração break estiver no laço interno, ele será abandonado e o controle será passado para o laço externo. Porém, se estiver no laço externo, os dois laços serão abandonados e o controle passará para a próxima declaração após o laço externo.

Tanto a expressão de inicialização de variáveis, quanto a de incremento, podem conter mais de uma expressão, que deverão estar separadas por vírgula (,).

Por exemplo:


for (int j = 0, i = 10; j < 100; j++, i++)
{
      Console.WriteLine("{0}", i * j);
      if (i == 30)
            break;
}

Laços em decremento

Usando o laço for pode-se implementar laços cuja variável de controle decrementa, em lugar de incrementar.

Exemplo:

for (int j = 10; j > 5; j--)
{
      Console.WriteLine("{0}", j);
}

O laço foreach/in

Esse tipo de laço é usado para varrer arrays ou coleções. As vantagens em relação ao laço for são as seguintes:

    Não é preciso se preocupar com a avaliação da condição booleana para garantir a sua execução;
    Não é preciso se preocupar com a inicialização de variáveis com o seu incremento/decremento;
    Não é preciso se preocupar com a forma de extração do conteúdo do array ou coleção, já que ambos possuem formas diferentes de extração dos seus valores;
    Quando todos os elementos do array/coleção tiverem sido varridos, o laço foreach/in será abandonado.

Você verá esse laço em execução no tópico de coleções.


O laço while

O laço while é usado quando não se sabe o número de vezes que se deve executar um bloco de código, mas apenas a condição que deve ser satisfeita para executar o bloco dentro do while. Essa condição é uma expressão booleana que deverá ser verdadeira para garantir pelo menos a primeira iteração. A sua sintaxe é:

while (condição){
      declaração;
}
Para exemplificarmos a utilização do laço while, observe o código abaixo:
int numeroDigitado = 0;
while (numeroDigitado >= 0)
{
      Console.WriteLine("Digite um número: ");
      numeroDigitado = int.Parse(Console.ReadLine());
}
Repare que o código acima aguarda que o usuário digite um número. Caso esse número seja maior que 0, ele precisará digitar um novo número. Este código é repetido até que o usuário digite um número menor do que 0. Quem controla essa repetição é o laço while com a condição numeroDigitado >= 0. Ou seja, a leitura do novo número será solicitada até que o usuário digite um número menor do que 0. Perceba que sabemos que temos que repetir um determinado trecho de código (a leitura do número digitado pelo usuário), só não sabemos até quando este trecho deverá ser repetido (não sabemos quando exatamente o usuário vai digitar um número válido). Este tipo de situação caracteriza a utilização do laço while.

O laço do/while

Esse é um tipo de laço usado para que um bloco de código seja executado pelo menos uma vez. A condição a ser satisfeita se encontra no fim do bloco de código e não no começo, portanto, a verificação de repetição do código só é feita no final da execução do código que está dentro do bloco de repetição. Como no caso dos laços for e while, sua sintaxe é a seguinte:

do{
      declaração;
}while (condição)



Poderíamos reescrever o exemplo anterior utilizando o laço do/while. Ele ficaria da seguinte maneira:

int numeroDigitado = -1;
do
{
      Console.WriteLine("Digite um número: ");
      numeroDigitado = int.Parse(Console.ReadLine());
} while (numeroDigitado >= 0)

Repare que, independente do valor inicial da variável numeroDigitado, o código de leitura do número digitado pelo usuário ia ser executado no mínimo uma vez. Somente após a digitação do número por parte do usuário é que a condição de repetição do laço do/while iria ser feita, já que esta verificação é feita somente no final da execução do código dentro do bloco.