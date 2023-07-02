Criando um projeto C#

Como vimos, para criar um novo projeto, selecione a opção File > New > Project, que a caixa de diálogo New Project será exibida:

À esquerda temos as categorias dos templates instalados, elas podem variar de acordo com as versões e os recursos instalados no Visual Studio. No nosso caso, selecione a categoria Visual C#, para listar todos os templates disponíveis para a linguagem C#. Certifique-se de ter escolhido de fato a categoria Visual C#, pois pode ser que, dependendo do Visual Studio que você tenha instalado ou as opções que você tenha selecionado ao iniciar o Visual Studio pela primeira vez, que a categoria padrão seja “Visual Basic”.

No painel central, onde são listados todos os templates da linguagem, selecione a opção Console Application, conforme a imagem acima.

No campo Name (nome) digite HelloWorld. Você também pode alterar o caminho onde sua aplicação será salva (Location) e o nome da Solução (Solution name). A janela deverá ficar similar à exibida abaixo:

Clique em OK para criar o projeto. Uma janela similar à abaixo será exibida:

Note que temos a barra de menus, que possibilita o acesso a comandos que podemos utilizar no ambiente de desenvolvimento. À esquerda temos a Toolbox, mas não a utilizaremos no momento. A direita temos a aba de Solution Explorer que mostra a estrutura do projeto, e abaixo temos a aba Properties (Propriedades).

O ponto mais importante é o editor central, que será o local que informaremos os códigos. Mas antes disso, vamos entender a estrutura do projeto.


Entendendo o projeto criado

Como foi dito acima, na aba Solution Explorer são mostrados os nomes dos arquivos associados ao seu projeto. Você pode dar um clique duplo sobre o nome do arquivo para exibi-lo no editor (ou painel de código - code panel). No nosso caso temos os arquivos:

Onde temos:

    Solution 'HelloWorld': essa é a nossa solução. Uma solution pode ter vários projetos associados como mostra na imagem acima, porém, no nosso caso, só existe um projeto, o projeto HelloWorld;
    HelloWorld: esse é o nosso projeto. Todos os arquivos que formos criar para este projeto estarão contidos nele;
    Properties: Essa é uma pasta que contém o arquivo AssemblyInfo.cs. Ele é um arquivo de código do C#, que contém atributos e informações que serão referentes ao executável da aplicação; como por exemplo, nome do autor, data em que foi escrito, entre outros.
    References: Essa é uma pasta que contém as referências de bibliotecas que o projeto utiliza ou pode utilizar;
    App.config: Arquivo de configuração da aplicação. Nele, podemos adicionar configurações gerais para aplicação; além de que, quando o executável do programa é gerado, é possível alterar esse arquivo sem a necessidade de criar novamente o executável;
    Program.cs: Esse é o arquivo inicial da aplicação. É através dele que outros arquivos são executados, por isso que ele é gerado automaticamente pelo Visual Studio. Desta forma será nele que iremos incluir o nosso código.

Além desses arquivos, se clicarmos em Show All Files:

Serão exibidas mais duas pastas:

Na pasta bin temos os arquivos do executável do projeto:

No momento só temos o arquivo de configuração do projeto (HelloWorld.exe.config) nessa pasta, porque ainda não executamos o projeto. Os arquivos *.vshost, são arquivos de hosting process, que é um recurso introduzido no Visual Studio 2005, para melhorar o desempenho da depuração (veremos depuração a frente no curso).

Dentro da pasta bin, também pode existir uma pasta Release, dependendo do tipo de execução do projeto.

Já na pasta obj:

Temos arquivos intermediários e/ou objetos, que são arquivos binários que ainda não foram vinculados. Basicamente são fragmentos que serão combinados para criar o executável final.

Como não mexeremos nessas pastas, clique novamente a opção Show All Files, para escondê-las:

Agora que vimos todos os arquivos do projeto, vamos ver código.

Projetos no Visual Studio com C#

Um projeto contém todos os arquivos necessários para seu aplicativo, incluindo não apenas arquivos de código-fonte, mas também arquivos de recursos como ícones e referências a arquivos externos que seu programa depende.

Quando você cria um projeto utilizando o C#, o Visual Studio chama o compilador C# e outras ferramentas internas para criar um conjunto executável usando os arquivos de seu projeto.

Observe a janela do Solution Explorer:

O nó Properties representa definições de configuração que se aplicam a seu projeto inteiro e são armazenados no arquivo .csproj na sua pasta solução:

Essas configurações incluem opções de compilação, segurança, configurações de implantação e muito mais.

Designer de projeto

Você faz modificações em seu projeto usando o Designer de Projeto, que é um conjunto de Páginas de Propriedades. Você pode acessar o Designer de Projeto clicando com o botão direito do mouse no projeto (não na solução) e logo depois em Properties:

Onde:

    Assembly name: Especifica o nome do arquivo de saída;
    Default namespace: Especifica o namespace padrão (verificaremos à frente o que são namespaces) para os arquivos do projeto;
    Output type: Especifica o tipo do aplicativo que será criado;
    Assembly Information: Através desta caixa de diálogo é possível especificar os valores dos atributos no arquivo AssemblyInfo criado automaticamente com o projeto (veremos mais detalhes a seguir);
    Startup object: Define a classe que será chamada quando o aplicativo for carregado. Somente classes que possuam um método Main podem ser especificadas aqui, pois este será considerado o método de entrada de sua aplicação. Caso existir apenas uma classe com esse método, ela sempre será chamada por padrão;
    Resources: As opções a seguir permitem-lhe definir configurações gerais para o aplicativo:
        Icon and manifest: Permite que você escolha um arquivo de ícone (*.ico) para ser usado como o ícone do aplicativo. Também permite especificar se o aplicativo será criado com um arquivo manifest (que é a opção padrão).
        Resource File: Para adicionar um arquivo de recurso do Windows (*.res) para o projeto.


Assembly Information

Através da caixa de diálogo Assembly Information podemos especificar os valores dos atributos no arquivo AssemblyInfo.cs criado automaticamente com o projeto. Os valores especificados nessa caixa de diálogo serão colocados nas meta-informações do arquivo principal gerado pelo nosso projeto. A caixa de diálogo tem a seguinte aparência:

Onde:

    Title: Especifica um título para o arquivo gerado;
    Description: Especifica uma descrição opcional para o arquivo;
    Company: Especifica um nome da empresa que desenvolve a aplicação;
    Product: Especifica o nome de produto do qual a aplicação faz parte;
    Copyright: Especifica um aviso de copyright;
    Trademark: Especifica uma marca para a aplicação;
    Assembly Version: Especifica a versão da aplicação;
    File Version: Especifica um número de versão que instrui o compilador para usar uma versão específica para o recurso de versão de arquivo Win32.
    GUID: Um GUID exclusivo que identifica a aplicação. Quando você criar um projeto, o Visual Studio gera uma GUID para o conjunto automaticamente;
    Neutral Language: Especifica as características de idioma (cultura), como o idioma em si, formatos numéricos, entre outros; que a aplicação suporta;
    Make assembly COM-Visible: Especifica se tipos no conjunto serão acessíveis para COM. Não é necessário se preocupar com COM neste momento.

Estas informações ficam gravadas junto ao seu arquivo executável. Para visualizá-las, primeiramente, clique com o botão direito sobre o projeto HelloWorld e selecione a opção “Build”, para que o executável seja criado. Logo após, localize o arquivo executável (deve estar dentro da pasta onde você criou o projeto/bin/debug), clique com o botão direito do mouse e selecione Propriedades. Logo após, selecione a aba “Detalhes” e verifique os atributos que foram preenchidos anteriormente: 

Executando o projeto

Antes de executarmos o projeto, vamos adicionar um código no nosso arquivo Program.cs:

Note que nele, temos o namespace HelloWorld (veremos sobre namespace a frente) e a definição de uma classe chamada Program que contém o método Main. Todos os métodos precisam ser definidos dentro de uma classe. O método Main é especial porque é por onde o controle de execução inicia e termina. É nele que criamos os objetos e chamamos a execução de outros métodos. É um método static (estático) que reside por padrão na classe Program. Não se preocupe se você ainda não entendeu sobre classe e método, a explicação será retomada a frente no curso.
Dica

O C# é case-sensitive, ou seja, ele diferencia letras minúsculas de maiúsculas. Assim, um M é interpretado diferente de um m. Consequentemente, Main é diferente de main.

Como primeiro exemplo, vamos fazer o clássico Hello World. Desta forma, dentro do método Main, entre os colchetes, digite: Console, conforme mostra a imagem abaixo:

A classe Console contém os métodos para exibir mensagens na tela e pegar as entradas do teclado. Tudo que o usuário digita no teclado pode ser lido através da classe Console. Ela só é significante para aplicações que rodam no prompt de comando, como neste exemplo.

Agora digite um ponto (.) depois de Console:

Note que aparece uma lista com as opções que podemos usar com a classe Console. No Visual Studio, essa lista é chamada de IntelliSense. O IntelliSense não é um recurso exclusivo do Visual Studio. Outras IDEs também possuem recursos similares. A função dessa lista é auxiliar durante a programação, principalmente em linguagens case-sensitive, como é o C#. O IntelliSense exibe todos os métodos, propriedades e campos da classe, além de uma descrição da opção de acordo com a documentação, como mostra na imagem acima.

Agora selecione WriteLine (você pode usar o Mouse ou o Teclado): tecle Enter ou dê um clique duplo sobre o WriteLine.

O IntelliSense é fechado e o método WriteLine é adicionado ao código. Como mostra a imagem abaixo:

Quando o IntelliSense aparece você também pode pressionar W para ir direto ao primeiro membro do método Console que começar com w. Também é possível forçar a exibição do IntelliSense com o atalho Ctrl+Space se não tiver nenhum problema no código: a lista será exibida no local onde o cursor se encontrar.

Abra um parêntese:

O IntelliSense mostra os parâmetros do método WriteLine. Isso ocorre com qualquer método que você vier a utilizar. O método WriteLine tem o que se chama de sobrecarga (Overload). Para cada sobrecarga do método WriteLine usam-se parâmetros diferentes. Cada sobrecarga, e seus respectivos parâmetros, podem ser visualizados clicando-se com o mouse na seta do IntelliSense, ou navegando pelas setas do teclado. Adiante, você verá o conceito de sobrecarga.

Feche o parêntese e digite ponto-e-vírgula (;). Deve ficar da seguinte forma:

Digite entre os parênteses a string “Hello World”, entre aspas. Você aprenderá sobre os tipos de dados mais à frente, o importante agora é saber que string é um tipo de dado. Deve ficar assim:
Dica

Habitue-se a digitar os pares de caracteres juntos como ( e ) e { e }, antes de entrar com seus respectivos conteúdos. Assim você evitará alguns erros por se esquecer de fechar alguma coisa.

Um asterisco depois do nome do arquivo no painel de código indica que foram feitas modificações no código do respectivo arquivo e que tais alterações ainda não foram salvas. Você também verá que as linhas que foram modificadas, mas ainda não foram salvas terão uma faixa amarela na frente. Você pode salvar manualmente, mas o Visual Studio salva automaticamente todos os arquivos antes de compilar a aplicação.

Agora você irá compilar a aplicação. No menu Build, clique em Build Solution. Se tudo estiver certo aparecerá a seguinte linha na janela Output:

========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========

Para exibir a janela de Output, na barra de menus clique em View > Output – ou pressione Ctrl+W,O:

No menu Debug, clique em Start Without Debugging (ou utilize o atalho Ctrl+F5) para executar o programa no prompt de comando:

O programa vai escrever Hello World como mostra a ilustração acima.
Dica

O Start Without Debugging foi escolhido para forçar uma pausa no final da execução. Se fosse clicado em Start ele iria executar o programa e fechar o prompt de comando logo após a execução, de forma tão rápida que não se conseguiria ver o que foi escrito. Experimente.

Com o foco no prompt de comando, pressione qualquer tecla para fechá-lo.

omentários

Comentários são textos inseridos no código e que são desprezados pelo compilador, ou seja, não são levados em consideração ao gerar a aplicação. Eles são utilizados para documentar o código, o que facilita quando for necessário alterar um código em que não se mexe há muito tempo. No C# os comentários podem ser por linha ou por bloco.

Por linha:

// Os comentários por linha se iniciam com duas barras
Por bloco: 
/*
Comentários por bloco.
Esse tipo de comentário pode conter várias linhas.
Iniciar com "barra-asterisco" e terminar com "asterisco-barra".
*/

Evite fazer comentários desnecessários no código, pois pode dificultar sua legibilidade e manutenção. 