Variáveis e operadores

Ao declarar uma variável no C#, é preciso determinar o tipo de dado que será armazenado nela. O tipo de dado vai dizer quais valores são possíveis de se armazenar nessa variável.

Quem define as regras para os tipos de dados como declaração, uso e gerenciamento dos tipos, como vimos anteriormente, é o CTS – ou Common Type System – que faz parte do CLR. O CTS, além de tornar possível desenvolver em linguagens diferentes na mesma plataforma e garantir total integração entre elas, é responsável por garantir o tipo de dado e aumentar o desempenho da execução.

Variáveis são espaços na memória do computador reservados para armazenar dados. A cada vez que você cria uma variável, você está “pegando” uma pequena porção de memória do computador para guardar alguma informação. A quantidade de espaço a ser “pego” vai depender do tipo de dado que a variável vai armazenar.

A referência aos dados de uma variável pode ser feita de duas maneiras:

    Por valor, chamado de Value-Type.
    Por referência, chamada de Reference-Type.

A principal diferença entre os dois tipos é que a referência a uma variável Value-Type contém diretamente um dado, enquanto a variável Reference-Type contém uma referência ao dado. Analise um pouco mais esses dois tipos de variáveis:

alue-Type

    Contém diretamente o dado;
    Cada cópia da variável contém uma cópia do dado independente;
    Operações em uma variável não afetam a sua cópia, pois elas são independentes;
    Exemplos de variáveis Value-Type são: integers, doubles, floats e structures.

Reference-Type

    Armazena uma referência ao dado (conhecido como objetos);
    Duas variáveis Reference-Type podem conter a referência a um mesmo objeto, ou seja: elas funcionam como ponteiros para posições da memória. É possível haver dois ponteiros para uma mesma posição de memória;
    Operações em uma afetam a outra, pois duas variáveis reference-type podem apontar para a mesma posição de memória e, consequentemente, para o mesmo objeto;
    Exemplos de Reference-Type são: strings, arrays e classes.

Aprenda agora a declarar variáveis, seus principais tipos e como atribuir e recuperar valores.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 3;
            int numero2 = 1;
            numero1 = 5;
            Console.WriteLine("numero1 = {0}, numero2 = {1}", numero1, numero2);
            Console.ReadKey();
        }
    }
}


/// passagem de valor
 int numero1 = 3;
            int numero2 = numero1;
            numero1 = 5;


///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // pssagem por valor
            // int numero1 = 3;
            //int numero2 = numero1;
            //numero1 = 5;
            Teste teste1 = new Teste();
            teste1.Quantidade = 3;
            Teste teste2 = teste1;
            teste1.Quantidade = 5;

            Console.WriteLine("teste1 = {0}, teste2 = {1}", teste1.Quantidade, teste2.Quantidade);
            Console.ReadKey();
        }
    }
    class Teste
    {
        public int Quantidade;
    }
}

/// passagem por referencia


// stack // int bool float double e structs
// rip // classe ponteiros

Nomeando uma variável

A documentação do .NET Framework dá as seguintes recomendações para a nomeação das variáveis:

    Evite usar underline no meio do nome;
    Não crie variáveis que se diferenciem apenas por sua forma. Exemplo: minhaVariavel e outra chamada MinhaVariavel. O indicado é que o nome da variável represente sua função. Exemplo: cont como nome de uma variável que será um contador;
    Procure iniciar o nome com uma letra minúscula;
    Evite usar todas as letras em maiúsculo;
    Quando o nome tiver mais que uma palavra, a primeira letra de cada palavra após a primeira deve ser maiúscula (conhecido como notação Camel Case);
    Não use notação húngara, onde as primeiras letras representam o tipo da variável. Exemplo: Snome para uma variável String.
    Não use acentos ou caracteres especiais nos nomes. Mesmo que o C# permita nomes com acentos, em alguns sistemas, isso pode gerar erros.

O uso de letras maiúsculas e minúsculas

A documentação do .NET Framework recomenda duas nomenclaturas para a criação de variáveis, funções e métodos em geral.

Temos a convenção Pascal Casing, onde a primeira letra do nome é maiúscula; e o mesmo nas palavras subsequentes. Exemplo:

class PessoaFisica{
...
}


É recomendado usar o Pascal Casing quando estiver nomeando classes, Enums (enumeradores), interfaces, constantes, campos somente leitura, métodos, eventos, namespaces e propriedades.

Temos também a convenção camel Casing, onde a primeira letra do nome é minúscula e, nas palavras subsequentes, a primeira letra é maiúscula.

int loopCountMax;


É recomendo usar essa convenção na nomeação em variáveis locais e variáveis que definem campos e parâmetros.

Para maiores informações sobre convenção de nomes veja a documentação do .NET Framework em: http://msdn.microsoft.com/en-us/library/ms229002%28v=vs.100%29

Palavras reservadas

A linguagem C# reserva cerca de noventa e nove palavras para seu próprio uso. Elas são chamadas palavras reservadas e cada uma tem uso particular, não podendo ser usadas como nome de variáveis. Segue a lista que identifica todas essas palavras: 

No Visual Studio as palavras reservadas são identificadas pelas letras em cor azul em geral.
Dica

Caso seja realmente necessário chamar uma determinada variável com o nome de uma palavra reservada para, por exemplo, garantir clareza ao código, você pode utilizar o símbolo @ (arroba) na frente do nome da variável. Assim, o compilador vai entender que, apesar de você estar utilizando uma palavra reservada, você na verdade quer nomear uma variável. Exemplos de declarações: string @string, int @readonly, long @join, etc.

Tipos de dados

Como toda linguagem de programação, o C# tem seus tipos de dados básicos que são comuns a todas as linguagens habilitadas ao .NET. Isso significa dizer que um inteiro (int) em C# tem a mesma estrutura e quantidades de bytes que um inteiro (Integer) em VB.NET. Na verdade, int (um inteiro de 32 bits em C#) e Integer (um inteiro de 32 bits em VB.NET) são apenas alias (apelidos) para os tipos ‘reais’ do CTS (Common Type System). Veja a tabela:

Tipo
	

Tipo .NET (CTS)
	

Faixa de dados
	

Valor padrão

bool
	

System.Boolean
	

true ou false
	

False

byte
	

System.Byte
	

0 a 255
	

0

char
	

System.Char
	

U +0000 a U +ffff
	

'\0'

decimal
	

System.Decimal
	

(-7.9 x 1028 to 7.9 x 1028) / 100 a 28
	

0.0M

double
	

System.Double
	

(+/-)5.0 x 10-324 to (+/-)1.7 x 10308
	

0.0D

float
	

System.Single
	

-3.4 x 1038 a + 3.4 x 1038
	

0.0F

int
	

System.Int32
	

-2,147,483,648 a 2,147,483,647
	

0

long
	

System.Int64
	

-9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
	

0L

Object
	

System.Object
		

(Classe base)

sbyte
	

System.Sbyte
	

-128 a 127
	

0

short
	

System.Int16
	

-32,768 a 32,767
	

0

string
	

System.String
		

null

uint
	

System.UInt32
	

0 a 4,294,967,295
	

0

ulong
	

System.UInt64
	

0 a 18,446,744,073,709,551,615
	

0

ushort
	

System.UInt16
	

0 a 65,535
	

0

Ou seja: float, por exemplo, é apenas um apelido para System.Single (Tipo .NET). Todos os tipos na tabela, com exceção dos tipos object e string, são conhecidos como tipos simples. Para retornar o tipo de qualquer variável do C# você pode usar o método GetType(); como mostra o exemplo:

using System;

class TipoVariavel
{
      public static void Main()
      {
            int minhaVariavel = 10;
            //Aparece o tipo da variável
            Console.WriteLine(minhaVariavel.GetType());
      }
}
Isso retornaria o tipo da variável minhaVariavel, neste caso, System.Int32. 

Declarando variáveis

Diferente de algumas linguagens, no C# é necessário declarar uma variável antes de usá-la. Nesse momento, aloca-se espaço na memória para a variável, que varia de acordo com o tipo de dado informado para a variável. Esse tipo de dado informa o tipo de dado que pode ser armazenado nela. Esse tipo de declaração é feito especificando o tipo de dado seguido do nome da variável:
<tipo de dado> <nome da variável>;


Como no exemplo:

int contador;
Ou: 
string nome;


Pode-se também declarar múltiplas variáveis do mesmo tipo de uma vez da seguinte maneira:

int contador, numeroCarro;
Ou: 
string nome, modelo;

 Como foi dito antes, C# é case-sensitive, ou seja, diferencia letras maiúsculas e minúsculas. “int num1” é diferente de “int Num1”!
Dica

Evite criar duas variáveis com o “mesmo nome”, onde o que as difere são as letras maiúsculas e minúsculas.


Atribuindo valores às variáveis

Depois de declarar a variável é preciso atribuir-lhe um valor. No C# você não pode usar uma variável antes de dar um valor a ela, o que geraria um erro de compilação. Veja um exemplo de como atribuir um valor a uma variável:

int numeroFuncionario;
numeroFuncionario = 23;



Primeiro, declara-se a variável do tipo int. Depois se atribui o valor 23 a ela. O sinal de igual é entendido como atribuição. Assim, numeroFuncionario recebe 23. Também é possível atribuir um valor à variável quando a declaramos:

int numeroFuncionario = 23;
Isso faz a mesma coisa que o exemplo anterior, só que tudo em uma linha. 

Tipagem implícita

A partir da versão 3.0 do C#, foi introduzido o conceito de tipagem implícita, onde não é necessário informar o tipo da variável. Isso será definido pelo valor que ela receber. Para utiliza-la, basta declarar a variável da seguinte forma:

var <nome da variável> = <valor>;
Por exemplo: 
var cont = 1;
Ou: 

var nome = "João";
Note que é necessário sempre informar o valor da variável no momento que é declarada, porque será desta forma que o tipo da variável será definido. Quem acaba se encarregando de definir o tipo das variáveis é o próprio compilador.

Constantes

Constantes, como o próprio nome sugere, são variáveis em que uma vez definido o valor, este não pode ser mudado pelo programa. Exemplo:

const double PI = 3.1415;



Repare que, para declarar a constante antes do tipo da variável, é informado a palavra-chave const, e que o nome da variável está capitalizado, por convenção, para diferenciar uma variável normal de uma constante, ela é nomeada com o nome capitalizado.

Vale lembrar que uma constante deve sempre ser inicializada na declaração, caso contrário, será gerado um erro.
