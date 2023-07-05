Vetores ou arrays e matrizes

Você já deve ter ouvido falar sobre vetores e matrizes na escola. Em programação também se lida com esses elementos, que são conhecidos como array unidimensional (vetores), bidimensional (matrizes) e multidimensional. Aprenda um pouco sobre cada um deles: Em C#, os arrays são objetos cuja classe-base é System.Array.

Vetores ou arrays são estruturas de dados capazes de armazenar múltiplos valores. Cada valor pode ser localizado por uma “chave”; no caso dos arrays, seria o índice correspondente à sua posição.

Declarando arrays

Para armazenar uma sequência de 10 números, até o momento foi conhecida apenas uma maneira:

int numero1 = 1;
int numero2 = 2;
int numero3 = 3;
int numero4 = 4;
int numero5 = 5;
int numero6 = 6;
int numero7 = 7;
int numero8 = 8;
int numero9 = 9;
int numero10 = 10;
Mas, dessa forma, o código não ficará muito legível... Então, a melhor solução seria assim: 
int[] numero = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
Pronto, este é um array em C#! Existem outras formas de inicializar um array quando a declaração é feita: 
int[] arrInt = new int[2] {0,1};
ou...
int[] arrInt = new int[ ] {0,1};
ou...
int[] arrInt = {0,1};
Como você pode notar, quando se declara um array é necessário utilizar os colchetes []. Por exemplo: 
int [] arrInt;
Sendo que se pode, no momento da declaração, informar o número de elementos: 
int[] arrInt = new int[10];

Note que é necessário utilizar o new. Se ele não fosse utilizado, ocorreria um erro de compilação, pois nosso vetor ou array estaria declarado de maneira errada. 

Definindo o número de elementos do array e acessando seus elementos

Quando se inicializa o array na declaração não é obrigatório informar o número de elementos. Também não é obrigatório quando ele é só declarado. Mas, para utilizá-lo depois da declaração, é preciso informar o número de elementos, que pode ser feito da seguinte maneira:

int[] arrInt = new int[10];



Com a declaração acima, você tem um array chamado arrInt do tipo int e que pode armazenar até 10 elementos do tipo int.

Para se acessar os elementos dentro de nosso array, você deve utilizar o índice correspondente à cada posição. O primeiro elemento dentro de um array é identificado pelo índice 0, o segundo pelo índice 1, e assim sucessivamente. Repare no código abaixo.

int[] arrInt = new int[10];
arrInt[0] = 2; // O valor 2 vai para dentro da primeira posição do array
arrInt[9] = 4; // O valor 4 vai para dentro da última posição do array
Console.WriteLine("O primeiro número do array é {0}", arrInt[0]);
Console.WriteLine("O último número do array é {0}", arrInt[9]);



Repare que, para fazermos a atribuição de um valor para uma posição do array de inteiros, nós precisamos especificar o índice entre colchetes e utilizar o sinal de atribuição como se fossemos fazer a atribuição à uma variável “normal”. Na hora de pegar o conteúdo presente, também devemos especificar o índice da posição da qual precisamos recuperar o valor. Também podemos utilizar como se fosse uma variável inteira “convencional”.
Dica

Não se esqueça: as posições dos vetores em C# (e na maioria das linguagens) começa com a posição 0. No exemplo do arrInt, temos um vetor de 10 posições, onde a primeira posição é a posição 0 (não a posição 1) e a última é a posição 9 (não a posição 10).

Arrays como objetos

No C#, arrays são objetos e não apenas regiões endereçáveis de memória contígua como em C e C++. Isso nos permite utilizar as propriedades, e outros membros da classe Array. Um exemplo disso é a propriedade Length para obter o comprimento de uma matriz:



A classe System.Array fornece vários outros métodos e propriedades, como:

Rank: Propriedade que retorna o número de dimensões de um array multidimensional (que veremos a frente). Exemplo:
Rank: Propriedade que retorna o número de dimensões de um array multidimensional (que veremos a frente). Exemplo:
Result = multInt.Rank;
Length: Propriedade que retorna o número total de elementos de todas as dimensões de um array multidimensional. Exemplo: 
Result = multInt.Lentgh;
C# (C Sharp)

GetLenght: O método retorna o número total de elementos de uma dimensão específica do array. Recebe como parâmetro um número inteiro que corresponde ao número da dimensão da qual se deseja saber o total de elementos. A numeração das dimensões começa por zero. Exemplo:

Result = multInt.GetLength(0);
Reverse: É um método estático cujo objetivo é inverter a ordem dos elementos do array. Essa inversão pode ser completa ou parcial, indicando o índice inicial e final para a inversão do array. Exemplo: 
int [ ] arr = new int[5] {1,2,3,4,5};
Array.Reverse(arr,1,2); // Invertendo o array parcialmente
Array.Reverse(arr); // Invertendo o array completamente
Sort: Ordena o array passado como parâmetro. Exemplo: 
int [ ] arr = new int[5] {1,3,5,2,0};
Array.Sort(arr);
IndexOf: Retorna a posição de um elemento no array, se não for encontrado é retornado -1. Exemplo: 
int[] m = { 2, 4, 6, 8, 10, 12};
int i = Array.IndexOf(m, 10);
MessageBox.Show("Posição = " + i.ToString());


Matrizes multidimensionais

Matrizes podem ter mais de uma dimensão. Por exemplo, a declaração a seguir cria uma matriz bidimensional de quatro linhas e duas colunas:

int[,] x = new int[4, 2];

x[0, 0] = 2;
x[0, 1] = 4;
x[1, 0] = 6;
x[1, 1] = 8;
x[2, 0] = 10;
x[2, 1] = 12;
x[3, 0] = 14;
x[3, 1] = 16;
ocê pode inicializar a matriz na declaração conforme mostrado no exemplo a seguir: 
int[,] x2 = { { 2, 4 }, { 6, 8 } , { 10, 12 }, { 14, 16 } };

Matrizes ou arrays multi-dimensionais

Uma matriz é um “vetor de vetores”. Ou seja, é como se fosse um vetor que possui vários vetores dentro. Um bom exemplo de matriz é uma planilha Excel.

Repare em uma planilha Excel: cada linha é como se fosse um vetor. A planilha em si também pode ser considerada um vetor: um vetor que contém vários outros vetores internamente (que é cada linha da planilha).

Matrizes, assim como vetores, também tem seus elementos localizados pela especificação dos índices do elemento.

Uma matriz convencional (matriz regular) é declarada da seguinte forma:
int[,] matriz = new int[2,2];


Nesse caso, criamos uma matriz quadrada, que possui duas linhas e duas colunas. É como se ela possuísse dois vetores de duas posições “um embaixo do outro”.

O processo para acessar as posições e atribuir valores a elas é bem similar ao processo para vetores. Observe o código:

int[,] matriz = new int[2,2];
matriz[0,0] = 2;
matriz[1,1] = 4;
Console.WriteLine("A primeira posição da primeira linha é {0}", matriz[0,0]);
Console.WriteLine("A última posição da última linha é {0}", matriz[1,1]);
Não se esqueça: assim como nos vetores, os índices de linha e coluna de uma matriz também começam em zero!
Matrizes irregulares

Uma matriz irregular é uma matriz cujos elementos são vetores diferentes entre si. Os elementos de uma matriz irregular podem ser de dimensões e tamanhos diferentes.

A seguir, há uma declaração de uma matriz dimensional única que tenha três elementos, cada um deles é uma matriz dimensional única (outro nome para vetores) de inteiros:

int [][] mi = new int[3][];
Antes de usar mi, seus elementos devem ser inicializados. É possível inicializar os elementos desta forma: 
mi[0] = new int[2];
mi[1] = new int[4];
mi[2] = new int[6];


Cada um dos elementos é uma matriz dimensional única de inteiros. O primeiro elemento é uma matriz de 2 inteiros, o segundo é uma matriz de 4 inteiros, e o terceiro é uma matriz de 6 inteiros.

Também é possível usar inicializadores para preencher os elementos da matriz com valores, caso em que não precisa informar o tamanho de matriz. Por exemplo:

E também podemos inicializar a matriz na declaração da forma abaixo: 
int[][] mi = new int[][]
{
      new int[] { 2, 4 },
      new int[] { 6, 8, 10, 12 },
      new int[] { 14, 16, 18, 20, 22, 24 }
};



Uma matriz irregular é uma matriz de vetores e, portanto, seus elementos são tipos de referência e são inicializados para null.

O método Length retorna o número de matrizes contidas na matriz irregular. Por exemplo, supondo que tenhamos declarado a matriz anterior, esta linha:

MessageBox.Show("Tamanho = " + mi.Length.ToString());


Retornará um valor de 3.

Para saber o tamanho de uma linha:

MessageBox.Show("Tamanho = " + mi[0].Length.ToString());
Retornará um valor de 2. 