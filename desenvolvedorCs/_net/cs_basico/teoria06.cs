Conversões de dados

Existem dois tipos de conversões:

    Explícitas.
    Implícitas.

Quando uma variável pode ser mais de um tipo, o recurso de conversão explícita pode ser usado. Veja:

int i;
double y = 10.5;
i = (int)y;
Foi atribuído um valor à variável i, do tipo int. Esse valor é a variável y que, por sua vez, é do tipo double e, nesse caso, fazendo uma conversão explícita (cast) de um tipo para o outro, para que fosse possível fazer a atribuição. Exemplo: 

using System;

class ConversaoExplicita
{
      public static void Main()
      {
            int i;
            double y = 10.5;
            i = (int)y;
            /*Aparece a conversão do valor 10.5 em inteiro, nesse caso, 10.
A parte decimal é desprezada, já que o tipo de dado  int não suporta pontos
 decimais   */
            Console.WriteLine("O valor 10.5 em inteiro é " + i);
      }
}



Já nas conversões implícitas isso ocorre de forma transparente nas atribuições de variáveis e passagens de parâmetros de métodos, desde que não se use o cast e os dados “caibam” um no outro. Veja:

long x;
int y = 5;
x = y;

C# (C Sharp)

No exemplo, pegou-se o valor de y e simplesmente atribuiu-se à variável x do tipo long, o que pode ser feito sem problemas, pois o tipo int cabe dentro do tipo long. Exemplo:


using System;

class ConversaoImplicita
{
      public static void Main()
      {
            long x;
            int y = 5;
            x = y;
            //Aparece a conversão do valor 5 para long
            Console.WriteLine("O valor 5 em long eh " + x);
      }
}

Como a variável x é long, que também é um tipo de dado inteiro, como a variável y, que é int (a diferença é que a long armazena uma faixa maior de valores), a conversão implícita ocorreu sem problemas. Se fosse o contrário (de long para int), a conversão implícita só ocorreria se o valor da variável long estivesse dentro dos valores permitido para o tipo int, caso contrário, daria um erro de estouro de memória. 