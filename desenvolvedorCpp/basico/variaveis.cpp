Variáveis Locais

#include<iostream>

using namespace std;

int main()
{
    int numero = 10;
    return 0;
}

Variáveis Globais

#include<iostream>

using namespace std;

int numero = 10;

int main()
{

    return 0;
}

Variável Static

Variáveis static, ao contrário de variáveis globais não podem ser acessadas de fora de sua função, porém isso não significa que ela seja idêntica a uma variável local. A principal diferença entre variáveis static e variáveis globais e locais é a capacidade que uma variável static tem de manter seu valor entre possíveis chamadas.

Essa característica é crucial principalmente na criação de algumas bibliotecas.

Lembrando que ao falar de variáveis static em C++ precisamos organizar o pensamento em dois temas distintos, as variáveis LOCAL STATIC e GLOBAL STATIC. Sendo assim vamos explicar cada uma delas.


Variável Local Static

Conforme já explicamos uma variável static tem a capacidade de manter seu valor entre chamadas, então veremos agora como declarar uma variável local static e suas características.

Declarar uma variável local static é muito simples basta seguirmos a seguinte regra:

PALAVRA STATIC tipo da variável NOME DA VARIAVEL;

static int variavel;



Fazendo isso já terá nossa variável static declarada.

Agora dois pontos importantes sobre esse tipo de variável são:

    Quando criada uma variável Local Static o compilador cria um armazenamento permanente para essa variável, bem parecido com o que acontece com variáveis globais.
    A única diferença é que uma variável global pode ser acessada de qualquer função já uma local static não.

    O grande trunfo desse tipo de variável é proporcionar ao programador criar funções que dependem de um valor que não pode ser zerado.

Veja um exemplo clássico (não compilável) do uso desse tipo de variável:

Função qualquer()
{
static int idade = 10;
idade = idade+1;
return(idade);
}

Variável Global Static

Agora vamos entender como funciona a variável global static que por sua vez tem o funcionamento de forma diferente da local static, pois enquanto a local static só é reconhecida dentro de sua função uma variável global definida como static pode ser acessível dentro do arquivo em que ela se encontra e não apenas em uma função.

Vamos ver como isso funciona na prática, observe um exemplo:

#include<iostream>

using namespace std;

static int x = 0;
void soma();

int main()
{
    soma();
    soma();
    soma();
    soma();

    return 0;
}

void soma()
{

    x = x + 1;

    cout << x << "\n";
}

Conversão de dados

Para ter êxito profissional todo programador precisa aprender a converter dados, e isso não é uma regra aplicada apenas aos programadores em C++, mas sim aos programadores de qualquer linguagem de programação, pois em qualquer linguagem hora ou outra será necessário converter algum tipo de dado.

Vamos supor que você criou uma função que execute cálculos que retornem como resultado números com ponto flutuante (o famoso número quebrado 3.8, 7.3) e pra piorar imagine que esse resultado foi gerado em um cálculo que tem apenas números inteiros.

O que você deverá fazer para pegar o resultado desse cálculo de forma exata?

A resposta para esse questionamento é a seguinte:

Você deverá convertê-lo.

Exatamente isso, simples assim! Podemos converter o resultado de qualquer operação matemática em um tipo de valor que satisfaça nossas necessidades.

Para fazer isso usamos o CAST ().

Observe um exemplo:

Resultado = (float) operação;


O exemplo acima mostra que estamos informando ao compilador que queremos armazenar na variável Resultado o valor da variável operação, porém não como inteiro, mas sim como um float.

Para reforçar esse conceito que ainda será visto muitas vezes no decorrer do curso, vamos mostrar abaixo um exemplo compilável. Observe:

Classes de armazenamento

Agora vamos falar de classes de armazenamento, que são as responsáveis por definir de que forma as variáveis serão gravadas e acessadas da memória do nosso computador.

Em C++ existem quatro classes de armazenamento que são: auto, extern, static e register. Vamos conhecer e analisar cada uma delas.

Auto

A classe auto é o padrão das variáveis locais, é uma declaração explicita de uma variável local que funciona seguindo as mesmas regras que estudamos anteriormente onde falamos que uma variável local só pode ser acessada de dentro de uma função ou bloco de código.

Essa mesma regra estudada anteriormente também é aplicada às variáveis definidas com a classe de armazenamento auto.

Veremos agora um exemplo desse tipo de classe:

int main()
{
  int Variavel;
  auto int Variavel2;
}

Extern

Vamos agora estudar a próxima classe de armazenamento que é a extern. Essa classe deve ser usada em variáveis globais e sua função é permitir ao programador referenciar variáveis que estejam em outros arquivos de código.

Lembrando que uma variável global é considerada global apenas no seu arquivo de código, em outros arquivos ela é desconhecida, sendo assim, para evitar a criação de várias variáveis, uma em cada arquivo de código, devemos declarar essa variável em arquivos adicionais usando a classe extern.

Fazendo isso estaremos dizendo ao compilador que essa variável já foi declarada em outro arquivo e que nesse arquivo de código queremos apenas referenciá-la.

Veja um exemplo abaixo:

//Arquivo – Externo.cpp

extern int Variavel_Ext;

Void Funcao01()
{
  Cout << "O valor da variável : Variavel_ext  = " << Variavel_ext;
}

//Arquivo – main.cpp

Int Variavel_Ext = 50;

Void main()
{
       Funcao01 ();
}

Agora que já entendemos a dinâmica dessa etapa vamos dar um exemplo a ser compilado.

//Arquivo – Codigo_Principal.cpp

#include<iostream>
using namespace std;
int Variavel01 = 100;
void Mensagem();

int main()
{
    Mensagem();
    return 0;
}
Arquivo Codigo02
#include<iostream>
using namespace std;
extern int Variavel01;
void Mensagem()
{
    cout<< "A variavel extern tem o valor de : " << Variavel01;
}

Static

Essa classe já foi estudada anteriormente, portanto já sabemos que uma variável que carrega essa classe de armazenamento tem a propriedade de preservar seu valor entre chamadas de função e que em C++ temos variáveis static globais e locais.

Register

As variáveis com a classe de armazenamento register tem a função de solicitar ao compilador que armazene seus dados em registradores da CPU e não na memória como acontece normalmente.

Isso faz com que as operações feitas com esse tipo de variável sejam bem mais rápidas que o comum.

Porém, tenha cuidado, pois valores pequenos podem ser armazenados em registradores à vontade, mas valores grandes como matrizes não.

Observe:

Constantes

As variáveis Constantes ou const são “variáveis” que não podem ter seu valor modificado pelo programa.

Uma const é muito útil principalmente em cálculos que exigem um valor que não pode ser modificado.

Imagine que você precisa desenvolver um programa que seja capaz de resolver cálculos baseado em valores constantes como, por exemplo, a gravidade, a velocidade da luz, enfim.

Para isso você deve concordar que para o programa funcionar corretamente ele não pode aceitar mudanças nesses valores que no “mundo real” nunca mudam, então a saída é definir um valor como gravidade ou velocidade da luz como uma constante.

Veja um exemplo de declaração e utilização desse tipo de variável:

#include<iostream>
using namespace std;
const float Gravidade = 9.78;
int main()
{
    int Valor01 = 5;
    float Resultado = Valor01 * Gravidade;

    cout << "O resultado obtido deve ser: " << Resultado;

    return 0;
}