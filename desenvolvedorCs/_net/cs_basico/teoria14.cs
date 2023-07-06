Coleções

Imagine que você precisa trabalhar com um conjunto de objetos, como por exemplo uma série de números inteiros. Para organizar estes projetos, você poderia utilizar um array para armazenar esta série de números. O código ficaria similar ao descrito abaixo.
int[] numerosDigitados = new int[10];
for (int i = 0; i <=9; i++)
{
      Console.WriteLine("Digite o número {0}: ", i + 1);
      numerosDigitados[i] = Convert.ToInt32(Console.ReadLine());
}


No código acima, nós lemos 10 números inteiros e armazenamos dentro do vetor numerosDigitados. Você tem uma quantidade fixa de números a serem lidos, neste caso, 10 números. Mas, o que aconteceria se você não soubesse ao certo a quantidade de números que fossem ser lidos? Como você iria criar o vetor, já que você precisa definir a quantidade de elementos que ele vai conter ao cria-lo?

Nesta situação, a utilização de estruturas rígidas como arrays e matrizes se torna inviável. Para este tipo de situação, o mais adequado seria utilizarmos collections ou coleções. Veja como o código poderia ficar se utilizássemos as coleções que o .NET nos oferece:

var numerosDigitadosList = new List<int>();
bool continuarLer = true;
while (continuarLer)
{
      Console.WriteLine("Digite um número: ");
      string dadoDigitado = Console.ReadLine();
      if (dadoDigitado.Equals("sair"))
      {
            continuarLer = false;
      }
      else
      {
            numerosDigitadosList.Add(Convert.ToInt32(dadoDigitado));
      }
}



Repare que nós utilizamos uma coleção, a numerosDigitadosList. Ela é uma coleção do tipo List, que especifica uma lista de objetos. Há vários tipos de coleções, porém, veremos mais à frente a diferença entre elas, pois é uma diferença na estrutura de dados que cada uma implementa. Em nosso caso, a collection List se comporta como um array de alocação dinâmica, ou seja: não é necessário definir a quantidade de elementos que ele vai comportar. À medida que novos elementos vão sendo adicionados à nossa collection, ele trata de alocar mais espaço na memória. Você pode armazenar quantos elementos julgar necessário em uma collection (como é o caso da List). Você, como dito anteriormente, não precisa definir também uma quantidade de elementos a serem armazenados.

Nas versões mais atuais do C#, você pode definir de que tipo de elementos a nossa lista será composta. No exemplo acima, nós definimos que nossa lista será composta por elementos do tipo int.

Alguns exemplos de outros tipos de coleções que o C# dá suporte são o ArrayList, a HashTable, o Dictionary e a SortedList. Não se preocupe, mais à frente nós iremos entender quando cada uma delas deve ser utilizada e suas diferenças.


Métodos principais comuns às collections

As collections, independente de sua implementação de estrutura de dados, apresentam alguns métodos em comum entre elas. Vamos ver alguns deles.

Add: adiciona um novo elemento à collection. O elemento a ser adicionado deve ser do tipo que foi especificado quando a collection foi definida. No exemplo que foi ilustrado anteriormente, definimos nossa collection List como uma lista de int (new List<int>()). Sendo assim, o método Add só aceitará um int como argumento para o método Add(). Repare na demonstração abaixo.

// List<[tipo]> lista = new List<[tipo]>();
// lista.Add([tipo]);
List<string> lista = new List<string>();
lista.Add("Isso é uma string");

Remove: remove um elemento da collection. Você precisa especificar um item do mesmo tipo da definição da collection. Caso o elemento exista dentro da collection, ele será removido; caso contrário, a collection não será modificada. Veja a demonstração abaixo.
// List<[tipo]> lista = new List<[tipo]>();
// lista.Remove([tipo]);
List<string> lista = new List<string>();
lista.Add("teste");
lista.Remove("teste");
Clear: “limpa” os elementos da collection, esvaziando-a.
List<string> lista = new List<string>();
lista.Clear();

IndexOf: retorna o índice que um elemento especificado ocupa dentro da collection. Assim como nos arrays, esse índice é iniciado com zero.
// lista.IndexOf([tipo]);
List<string> lista = new List<string>();
lista.Add("Primeiro elemento");
lista.Add("Segundo elemento");
int indice1 = lista.IndexOf("Segundo elemento"); // indice1 receberá 1
int indice2 = lista.IndexOf("Terceiro elemento"); // indice2 receberá -1, pois o elemento não existe na collection

Você pode também navegar entre as collections especificando um índice como chave, da mesma maneira como é feito nos arrays. 
List<string> lista = new List<string>();
lista.Add("Primeiro");
lista.Add("Segundo");
string a = lista[1]; //a vai assumir o valor "Segundo"
string b = lista[0]; //b vai assumir o valor "Primeiro"

Estes métodos são comuns a quase todas as collections, com algumas variações entre elas. Por exemplo, o método Add() em uma collection do tipo Dictionary recebe dois parâmetros ao invés de um único como ilustrado acima. Porém, a ideia do método é a mesma que foi apresentada aqui. Mais para frente, iremos utilizar as demais collections e mostraremos também suas variações.