Introdução ao C# e ao .NET Framework

C# (lê-se "ce charp") é uma linguagem desenvolvida pela Microsoft, apresentada no ano 2000, junto com a plataforma .NET, sendo a principal linguagem da plataforma. O C# é um híbrido de C++ e Java. Embora vários desenvolvedores tenham trabalhado no projeto, a criação da linguagem é atribuída principalmente a Anders Hejlsberg (chefe do projeto) que, em 2004, recebeu o título de "Distinguished Engineer" e foi agraciado pela revista "Doctor Dobbs Journal", em 2000, com o prêmio "Excelência em Programação". Hejlsberg era desenvolvedor de compiladores na Borland e entre suas criações estão o Turbo Pascal e o Delphi.

O C# é considerada uma linguagem orientada a objetos e type-safe, onde o objetivo da linguagem é a produtividade do programador. Para esse fim, a linguagem equilibra simplicidade, expressividade e desempenho.

Porque C#?

Com o suporte a várias linguagens dentro do ambiente .NET, porque escolher o C#? Isso irá depender do que você necessita fazer e do que gosta e não gosta em uma linguagem de programação. No caso do C#, ele nos fornece poder e flexibilidade para trabalhar em um nível de abstração alto o suficiente para não necessitar de muito esforço para resolver pequenos problemas.

Entre os recursos que o C# nos oferece, temos orientação a objetos, generics e programação funcional. Ele suporta tanto tipagem dinâmica e estática. O C# também nos fornece recursos orientados para o LINQ (Language Integrated Query, uma linguagem de consulta unificada a várias fontes de dados – desde datasets até estruturas de dados como listas e arrays) e possui suporte para programação assíncrona.

Alguns dos benefícios mais importantes do uso de C# vem dos seus recursos em tempo de execução, que nos oferece serviços como segurança sandboxing (execução de código dentro de um ambiente controlado), verificação de tipos em tempo de execução, tratamento de exceções, gerenciamento de thread e, talvez o recurso mais importante, o gerenciamento automático de memória. Em tempo de execução há um coletor de lixo (garbage collector), que livra os desenvolvedores de grande parte do trabalho associado à memória, recuperando o que não é mais usado pelo programa.

Claro que existem linguagens elegantes e academicamente bonitas que são lindas até na hora que for necessário fazer algo prosaico, como conectar ao banco de dados, ou armazenar as configurações do usuário. Não importa o quão forte é um conjunto de expressões que uma linguagem de programação oferece, ele também precisa fornecer acesso completo e conveniente de serviços da plataforma subjacente. E o C# é muito forte nessa área graças ao .NET (que veremos a frente).

Suporte a plataformas e tecnologias

O C# é normalmente utilizado para escrever programas que inicialmente rodam em plataformas Windows. Porém, graças ao fato de a Microsoft ter padronizado a linguagem através do ECMA, existem projetos (projetos estes inclusive com o apoio da Microsoft) para que seja possível rodar códigos C#.NET em outras plataformas. Podemos citar o Mono (http://www.mono-project.com/ ), que é uma implementação open-source do .NET Framework para distribuições Linux e para MacOS. Com o Mono, é possível executar códigos de qualquer linguagem do framework .NET (o que inclui o C#) em Linux e MacOS.

Você pode utilizar o C# para escrever código entre plataformas nos seguintes cenários:

    O C# pode ser executado para gerar aplicações web (inclusive com suporte para HTML5, CSS3, JavaScript e a grande maioria dos frameworks JavaScript e CSS) através do ASP.NET;
    É possível desenvolver aplicações desktop utilizando o C# através de projetos Windows Forms e WPF (Windows Presentation Foundation);
    Também é possível desenvolver web services e aplicações voltadas à arquitetura orientada a serviços através do WCF (Windows Communication Foundation);
    Você também pode desenvolver aplicações nativas para Windows Phone utilizando o C#;
    É também possível criar aplicações no estilo Console, embora não seja muito comum utilizar o C# para este tipo de aplicação.


Bibliotecas de código

Ao contrário das outras linguagens de programação, nenhuma implementação de C# atualmente inclui qualquer conjunto de bibliotecas de classes ou funções. Ao invés disso, o C# está muito vinculado ao framework .NET, do qual C# obtém suas classes ou funções de execução. O código é organizado em um conjunto de namespaces que agrupam as classes com funções similares.

Um nível de organização superior é fornecido pelo conceito de montador (assembly), que é na verdade um arquivo DLL. Uma única DLL pode conter muitos namespaces ou objetos, porém, na maioria das vezes, cada DLL possui elementos próprios para uma funcionalidade. Programas que precisam de classes para realizar uma função em particular podem se referenciar a montadores como System.Drawing.dll e System.Windows.Forms.dll, além da biblioteca core (conhecida como mscorlib.dll na implementação da Microsoft).

Conhecendo melhor o .NET Framework

O .NET Framework é uma infraestrutura (framework) sobre a qual se reúne um conjunto de linguagens e serviços que simplificam o desenvolvimento de aplicações. Mediante essa ferramenta se oferece um ambiente de execução altamente distribuído, que permite criar aplicações robustas e escaláveis. Os principais componentes desse ambiente, que serão detalhados a seguir, são:

    Linguagens suportadas pelo .NET;
    Biblioteca de classes comuns do .NET Framework;
    CLR (Common Language Runtime);
    JIT (Just-in-time Compiler)

O .NET Framework suporta múltiplas linguagens de programação e, embora cada linguagem tenha características próprias, é possível desenvolver qualquer tipo de aplicação com qualquer uma das linguagens. Existem mais de 30 linguagens adaptadas a .NET, desde as mais conhecidas como C#, Visual Basic.NET e C++, até outras linguagens menos conhecidas, como Perl ou Cobol.

Processo de compilação/execução de uma aplicação .NET e a arquitetura do framework

O processo de compilação e execução de uma aplicação dentro do ambiente .NET (não necessariamente só com o C#, mas com todas as linguagens que possuem implementação no framework) pode ser ilustrado pelo diagrama abaixo:

O processo de compilação e execução de uma aplicação .NET pode ser detalhado da seguinte maneira:

    Ambiente de desenvolvimento: é onde os desenvolvedores escrevem os códigos necessários para o desenvolvimento de uma aplicação. Geralmente, é utilizada uma IDE para auxiliar na escrita do código. Para a plataforma .NET, a IDE mais utilizada é o Visual Studio, da Microsoft;
    Compilação: após a escrita do código, é necessário o converter para uma linguagem de um nível mais baixo. No caso específico do C#, quem faz essa conversão, conhecida como compilação, é o executável csc.exe. No caso de utilização de IDEs, a própria IDE se encarrega de chamar o compilador com os parâmetros necessários, além de fazer uma série de verificações no código (por exemplo: verificação de erros de sintaxe);
    Assembly intermediário: no caso da plataforma .NET, o código-fonte é convertido para uma linguagem unificada da plataforma .NET, a Microsoft Intermediate Language (MSIL). Essa conversão ocorre devido ao fato de que a plataforma .NET possui várias implementações de diferentes linguagens que, inclusive, podem conversar entre si. Para isso, é necessário converter todos os códigos-fonte para uma linguagem única, que é a MSIL. Atualmente, a MSIL também é chamada de CIL (Common Intermediate Language). A CIL/MSIL se assemelha muito ao bytecode da plataforma Java.O MSIL/CIL ainda apresenta algumas meta-informações sobre as classes compiladas e seu conteúdo nos arquivos gerados pelo processo de compilação e conversão para a MSIL/CIL. É importante salientar que o resultado do processo de compilação e conversão para a MSIL ainda não é código de máquina (a MSIL/CIL ainda apresenta até uma certa legibilidade para humanos), e sim uma linguagem unificada intermediária da plataforma .NET. A conversão dos códigos escritos nas diferentes linguagens da plataforma .NET para a MSIL/CIL é feita de acordo com a Common Language Specification (CLS), um conjunto de funções básicas que todas as linguagens da plataforma devem conter para que seja possível que “uma converse com a outra”, além de conter o Common Type System (CTS), um conjunto de especificações para principalmente efetuar a conversão e correspondência de tipos de dados entre as diferentes linguagens;
    .NET Framework: é o conjunto de todos os utilitários e infraestrutura necessárias para se executar uma aplicação .NET na máquina-cliente. Os componentes principais do .NET Framework são:
        Common Language Runtime (CLR): o CLR é o verdadeiro núcleo do .NET Framework, já que é o ambiente de execução onde se carrega e gerencia os códigos MSIL/CIL;
        JIT (Just-in-Time Compiler): é o componente do .NET Framework responsável por converter os códigos MSIL/CIL para o código de máquina correspondente à plataforma onde a aplicação é executada. A CLR, quando detecta que é necessário um trecho de código que ainda não foi convertido para linguagem de máquina, solicita ao JIT essa conversão e, só depois, o código é executado, já no formato de máquina. Esse processo é conhecido como Dynamic Translation (“Tradução dinâmica”);
        Garbage Collector (GC): componente do .NET Framework que é responsável por verificar a memória da máquina cliente onde a aplicação é executada. Caso ele encontre uma localização da memória que contenha alguma informação que não é mais necessária para nenhum processo que esteja rodando dentro da plataforma .NET (por exemplo: uma referência para um objeto que não é mais utilizado em nenhum ponto de uma aplicação .NET), o GC limpa a região da memória que era utilizada para guardar esta informação e a libera, permitindo que novas informações úteis sejam gravadas naquela posição de memória;
        .NET Class Libraries: é um conjunto de bibliotecas próprias do .NET Framework utilizadas para interação com recursos da infraestrutura do framework e/ou recursos do sistema operacional. Essas bibliotecas são utilizadas por qualquer aplicação que seja escrita em cima do .NET Framework.

Ao final do processo de compilação e conversão da MSIL/CIL por parte do .NET Framework, é gerado um código de máquina que será gerenciado pela CLR. Este código de máquina está otimizado para o ambiente onde a aplicação está sendo executada, o que adiciona a característica de interoperabilidade ao .NET Framework: basta existir uma implementação da infraestrutura do .NET Framework para um sistema operacional que já se torna possível executar uma aplicação .NET neste sistema, sem necessidade de portabilidade e/ou reescrita de código para o sistema em questão. Isso também é possível graças à própria MSIL/CIL: no final, todo o código é convertido para uma única linguagem unificada, que não depende de sistema operacional: ela depende somente da própria infraestrutura do .NET Framework.
