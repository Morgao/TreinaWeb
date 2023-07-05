Debbugando” o código com o Visual Studio

O depurador ou debug é um programa desenvolvido para ajudar o programador na verificação e correção de erros. Ele vem embutido no Visual Studio e será utilizado para compreender como o programa funciona. Ele permite a execução do programa passo a passo.

Para verificarmos os recursos que o debug nos oferece, crie um novo projeto Console Application no Visual Studio. Chame este novo projeto de ConhecendoDebug.

Logo após, vamos criar três métodos dentro da classe Program que é gerada: o método LerInteiro(), o método CalcularSoma() e o método ExecutarPrograma().

O método LerInteiro() deverá conter o seguinte código:

int LerInteiro()
{
      Console.Write("Digite um número: ");
      return int.Parse(Console.ReadLine());
}



Este método irá somente fazer a leitura de um número inteiro qualquer que o usuário digitar.

O método CalcularSoma() deverá ser escrito da seguinte maneira:


int SomarNumeros(int num1, int num2)
{
      int resultado = num1 + num2;
      return resultado;
}



Este método irá receber dois números inteiros quaisquer e retornar o resultado da soma destes números.

O método ExecutarPrograma() deverá ser declarado da seguinte forma:


void ExecutarPrograma()
{
      int numero1 = LerInteiro();
      int numero2 = LerInteiro();
      int soma = SomarNumeros(numero1, numero2);
      Console.WriteLine("O resultado da soma é {0}", soma);
}



Este método será responsável por chamar o método LerInteiro() duas vezes para ler dois números digitados pelo usuário e, logo em seguida, fazer a soma destes números com o método SomarNumeros(). Logo após fazer a soma, o método irá escrever para o usuário qual é o resultado da soma.

Agora, digite o seguinte código dentro do método Main() da classe Program:


(new Program()).ExecutarPrograma();

O arquivo Program.cs ficará da seguinte maneira:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoDebug
{
      class Program
      {
            static void Main(string[] args)
            {
                   (new Program()).ExecutarPrograma();
            }

            void ExecutarPrograma()
            {
                  int numero1 = LerInteiro();
                  int numero2 = LerInteiro();
                  int soma = SomarNumeros(numero1, numero2);
                  Console.WriteLine("O resultado da soma é {0}", soma);
                  Console.ReadKey();
            }

            int LerInteiro()
            {
                  Console.Write("Digite um número: ");
                  return int.Parse(Console.ReadLine());
            }

            int SomarNumeros(int num1, int num2)
            {
                  int resultado = num1 + num2;
                  return resultado;
            }
      }
}



Compile o projeto, indo até o menu Build e logo depois na opção Build ConhecendoDebug. Caso não sejam apresentados erros, seu projeto foi compilado com sucesso.

Agora, execute o projeto como vimos anteriormente (através do atalho Ctrl + F5). Verifique que a leitura dos dois números é feita e o resultado da soma é exibido. Veja o resultado da execução de nosso algoritmo.

Agora vamos verificar como utilizar o recurso de debug do Visual Studio.

A primeira coisa que precisamos fazer é criar um breakpoint. Um breakpoint é um ponto de interrupção na execução de um trecho de código: quando o código executado chega na linha onde exista um breakpoint, a execução do trecho de código é pausada. A partir daí, você pode executar o algoritmo linha a linha, verificando inclusive o conteúdo de campos e variáveis. Esse tipo de recurso é fundamental quando precisamos verificar, por exemplo, uma situação em que nosso código está produzindo algum tipo de erro e temos que descobrir a razão disto.

Para criar um breakpoint, clique na barra cinza do lado esquerdo do editor de código. A cada clique, um breakpoint é criado. Os breakpoints são sinalizados através de um círculo vermelho que fica à frente da linha, além do fato de que a linha que contém o breakpoint ficará em um tom vermelho. Para nosso exemplo, vamos criar um breakpoint na linha onde o segundo número é lido. O editor de código deverá ficar da seguinte maneira:

Repare que nós colocamos o breakpoint no momento em que nosso programa fará a leitura do segundo número. Quando ele for ler o segundo número, ele deverá suspender a execução e permitir que nós inspecionemos as variáveis e campos da classe, além de nos permitir fazer o restante da execução passo-a-passo.

Execute nosso programa, porém, através do menu Debug > Start Debugging. Opcionalmente, você pode utilizar o atalho F5 ou apertar o botão com o play na barra acima do editor de código.

Digite o primeiro número. Logo após você digitar o primeiro número, você verá que a execução de nosso programa será pausada. Vá de volta à janela do Visual Studio e verifique que agora a linha onde existe nosso breakpoint estará amarela, além de haver uma seta amarela logo na linha onde colocamos o nosso breakpoint. Isso significa que o Visual Studio pausou a execução do software antes de executar a linha onde colocamos o breakpoint, no nosso caso, antes de ler o segundo número. A partir deste momento, o programa está sendo “debuggado”.

Agora, com o programa sendo “debuggado”, nós podemos, por exemplo, ver o valor que as variáveis possuem no momento. Faça um teste: posicione o mouse sobre a variável numero1. Verifique que o Visual Studio irá exibir o valor que esta variável possui no momento, em nosso caso, o primeiro número que você digitou.

O debug do Visual Studio também oferece outras ferramentas de debugging. Veja na parte inferior algumas janelas importantes.

A primeira que você verá é a janela Autos. Essa janela exibe os objetos e variáveis existentes na linha anteriormente executada e na linha atual. Ela também mostra seus valores atuais e seus tipos de dados. A coluna Value também permite a alteração dos valores atuais dentro de cada objeto e variável exibidos: basta clicar na linha correspondente e digitar o novo valor.

Na aba ao lado, você vê a janela Locals. A janela Locals exibe as mesmas coisas que a janela Autos, porém, ela exibe todas os objetos e variáveis que existem no escopo do método onde o breakpoint foi colocado. A coluna Value também é editável dentro da janela Locals.

Também temos a janela Watch. Nesta janela, é possível digitar expressões e ver seu resultado.

Vamos verificar o funcionamento da janela Watch. Clique na coluna Name na primeira linha. Logo após, digite numero1. A janela Watch deverá ficar da seguinte maneira:

Repare que o Visual Studio trouxe o valor da variável numero1, bem como seu tipo.

Agora, na linha de baixo de onde acabamos de digitar, clique mais uma vez na coluna Name e digite numero1 + numero2. A janela deverá ficar da seguinte maneira:

Repare que o Visual Studio trouxe o valor da somatória entre as variáveis inteiras numero1 e numero2. No caso da variável numero2, como o breakpoint foi colocado antes da atribuição de valor, ela fica com o valor padrão para variáveis inteiras, que é zero.

Veja que então é possível executar quaisquer expressões com a janela Watch. Essas expressões não se resumem a expressões matemáticas: você poderia, por exemplo, ver o resultado de uma operação Substring() em uma determinada string que existe em seu método.

É importante lembrar que a janela Watch enxerga somente variáveis que existam dentro do escopo do método onde o breakpoint foi colocado. Se você digitar uma expressão inválida, a coluna Value exibirá uma mensagem de erro.

Na janela ao lado, temos a aba Call Stack. Ela mostra o trace de nosso programa, ou seja: ela mostra as chamadas de métodos, bem como as linhas correspondentes às chamadas no código, que foram executadas até o momento. As chamadas mais antigas ficam nas linhas inferiores, enquanto as mais recentes ficam nas primeiras linhas desta aba.

Repare que a janela Call Stack também exibe o local onde o breakpoint foi colocado e qual linha está sendo executada atualmente no modo debug.

Por fim, temos a aba Breakpoints. Esta aba exibe todos os breakpoints que existem em todo o código da nossa solution.

Repare que a aba Breakpoints também nos mostra o arquivo onde existe o breakpoint, bem como a linha onde ele se encontra.

Pela aba Breakpoints, podemos também criar novos breakpoints, excluir os que já existem ou até mesmo desabilitar os breakpoints. Quando um breakpoint é desabilitado, ele não causa a interrupção da execução do código. Para desabilitar o breakpoint, basta desmarcar a pequena caixa de seleção ao lado do breakpoint. Para reabilitá-lo, basta clicar novamente na caixa de seleção.

Por hora, não precisamos dar atenção às janelas Command Window, Immediate Window e Output.

Para prosseguirmos com a execução do código após nosso programa ser interrompido pelo breakpoint, nós temos algumas opções:

    Podemos continuar a execução normalmente através do botão “Continue” ou então apertando novamente a tecla F5. Isso fará com que a execução de nosso programa ocorra normalmente, como se não tivesse sido interrompida pelo breakpoint;

    Nós podemos andar uma linha de nosso código, e somente uma linha. Para isso, podemos utilizar o menu Debug > Step Over, o botão Step Over da barra de debug ou então a tecla F10;

    Caso a linha onde o debugging esteja se trate da chamada de um método, nós podemos entrar neste método no modo Debug. Para isso, podemos utilizar o menu Debug > Step Into, o botão Step Into da barra de debug ou então a tecla F11.

Vamos verificar agora estas opções em ação!
Dica

A ferramenta de debug do Visual Studio oferece muito mais recursos do que estes. Porém, as que foram apresentadas até o momento são suficientes para continuarmos com o curso. As demais serão discutidas posteriormente.

Nosso código ainda deve estar com a execução parada onde colocamos nosso breakpoint, que é no momento de leitura do segundo número. No Visual Studio, utilize a opção Step Into ou aperte a tecla F11 para entrarmos no método LerInteiro(). Verifique que, logo após, o cursor que indica qual linha de código está sendo executada no momento será deslocado para a primeira chave do método LerInteiro(). Isso significa que a primeira linha do método LerInteiro() está prestes a ser executada.

Agora, utilize a opção Step Over ou pressione a tecla F10. Verifique que o cursor que indica qual linha está sendo executada no momento será deslocado para a próxima linha, sem entrar em qualquer outro método.

Antes de prosseguirmos, coloque um novo breakpoint dentro do método ExecutarPrograma() na linha onde o método SomarNumeros() é chamado.

Agora, pressione o botão Continue ou pressione a tecla F5. Verifique que a execução de nosso programa continuará até chegar no próximo breakpoint, que no caso, é o breakpoint que acabamos de inserir. A leitura do segundo número será solicitada como previsto dentro do método LerInteiro(). Digite um número inteiro para que a execução prossiga. Ao chegar na linha onde se encontra este novo breakpoint, a execução será interrompida novamente e o Visual Studio entrará novamente no modo Debug.

Agora, vá até a aba Watch. Verifique que o resultado da expressão onde tínhamos digitado numero1 + numero2 foi atualizado de acordo com os números que foram digitados.

Para confirmar que a expressão está correta no resultado, insira uma nova entrada no Watch para exibir o valor da variável numero2.

Antes de continuarmos, faça um teste: vá até a aba Locals e altere o valor da variável numero1 para um valor diferente do atual. Logo após, faça com que o programa continue a ser executado normalmente utilizando o botão Continue ou a tecla F5. Verifique que o resultado exibido da soma no console irá ser alterado de acordo com o valor que foi digitado na aba Locals.

Logo após este teste, encerre a execução do nosso programa pressionando uma tecla qualquer após a exibição do resultado.
Dica

A disposição das abas das ferramentas de debug pode variar de acordo com a versão do Visual Studio (2010, 2012, 2013, 14...) e também de acordo com a edição (Express, Professional...).
