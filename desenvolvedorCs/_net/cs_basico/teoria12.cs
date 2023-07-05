Tratamento de erros

Durante o desenvolvimento de nossas aplicações, é normal precisarmos prever alguma situação de erro e trata-lo, ou seja, executar alguma coisa quando ocorrer um erro. Um exemplo que podemos dar é uma aplicação que se conecta a um servidor de banco de dados. A conexão ao banco de dados depende da disponibilidade do servidor. Caso a aplicação não consiga se conectar à aplicação por indisponibilidade do servidor, isso caracteriza uma situação de erro. Uma coisa que a aplicação poderia fazer é exibir uma mensagem amigável para o usuário, informando que o servidor está indisponível no momento, ao invés de estourar uma mensagem de erro extremamente técnica para o usuário: é necessário tratar os erros que nossa aplicação pode sofrer.

Conhecendo os três tipos de erros

Três tipos de erros podem ser encontrados nos programas: erros de sintaxe, erros de Runtime e erros lógicos. Aprenda cada um deles.

Erros de sintaxe ou erros de compilação

Acontecem quando você digita de forma errada uma palavra reservada ou comando do C#. Você não consegue executar o programa quando há esse tipo de erro no código. Na verdade, você não consegue nem compilar e gerar a aplicação enquanto você não corrigir o erro em questão.

Erros de runtime

Acontecem quando o programa para de executar, de repente, durante a execução. Chama-se a essa parada de exceção.

Erros de runtime acontecem quando alguma coisa interfere na correta execução do código. O exemplo dado anteriormente com relação à conexão ao servidor de banco de dados é um exemplo de erro de runtime, pois a aplicação fatalmente não poderá ser executada e o programa, se o erro não for corretamente tratado, irá ser encerrado abruptamente.


Erros lógicos

Esse é o tipo de erro mais difícil de ser tratado, pois é um erro humano. O código funciona perfeitamente, mas o resultado está errado. Por exemplo: uma função deve retornar um valor, mas o valor retornado está errado; o erro nesse caso se encontra na lógica da função que está processando o cálculo. A grosso modo, é como se o programa precisasse fazer um cálculo de 2 + 2 em que o resultado certo é 4, mas ele retorna 3. Quando é uma conta simples é fácil de identificar, mas, e se o cálculo for complexo?

O bloco try-catch

Até agora você aprendeu a utilizar o Visual Studio para resolver erros lógicos e de sintaxe. A partir deste tópico você aprenderá a tratar erros de runtime através do try...catch, que é conhecido como uma estrutura de tratamento de erros ou estrutura de tratamento de exceções. Você pode usá-lo para reconhecer o erro de runtime que está ocorrendo no programa e, através disso, emitir uma mensagem de erro adequada e ajustar o programa com as condições necessárias para que continue executando.

A estrutura básica de um bloco try-catch é esta:

try
{
      // O código que você faria normalmente
}
catch [(Exception [ex])]
{
      // Código que será executado em situação de erro
}



Vamos a um exemplo mais concreto. Imagine que você precise ler um determinado arquivo para extrair algumas informações deste. Porém, corremos o risco de, na hora que nossa aplicação for executada, de o arquivo não existir. Tendo isto em vista, nós necessitaríamos emitir uma mensagem para o usuário caso o arquivo não existisse no local especificado.

Podemos utilizar a estrutura try-catch nesta situação. O código ficaria similar ao apresentado abaixo:
Dica

Não se preocupe com algumas estruturas diferentes neste código. Iremos aprendê-las mais à frente. Preocupe-se com os blocos try-catch.


try
{
      StreamReader stream = new StreamReader(@"C:\teste.txt");
      string linha;
      while((linha = stream.ReadLine()) != null)
      {
            // Tratamento da linha lida do arquivo texto
      }
}
catch
{
      MessageBox.Show("Erro ao manipular o arquivo");
}



No código acima, nós estamos abrindo um arquivo texto, o teste.txt, que está na unidade C. Após abrir o arquivo, ele é varrido e algum tipo de tratamento é feito com as linhas extraídas. Porém, pode ocorrer qualquer tipo de erro na manipulação do arquivo: ele pode não estar no local especificado, ou o computador pode não possuir memória suficiente para criar os buffers de leitura. Para tratar este tipo de erro, colocamos o bloco catch. O código colocado dentro do bloco catch será executado se ocorrer qualquer tipo de erro no código dentro do bloco try. Nesse exemplo, caso ocorra algum erro ao manipular o arquivo, será exibida uma mensagem ao usuário escrita “Erro ao manipular o arquivo”.

Você ainda pode especificar os tipos de exceções que deverão ser tratadas. Para isso, basta especificar a classe correspondente à exceção que você deseja tratar no bloco catch, colocando-a à frente da keyword catch entre parênteses. No exemplo anterior, nós podemos emitir uma mensagem para quando o arquivo não existe na unidade C (exceção de I/O) e uma outra para quando o computador não possuir memória suficiente para criar os buffers de leitura (exceção “Out of Memory”). O código ficaria da seguinte maneira:

try
{
      StreamReader stream = new StreamReader(@"C:\teste.txt");
      string linha;
      while((linha = stream.ReadLine()) != null)
      {
            // Tratamento da linha lida do arquivo texto
      }
}
catch (IOException)
{
      MessageBox.Show("O arquivo não existe na unidade C");
}
catch (OutOfMemoryException)
{
      MessageBox.Show("Sem memória para criação do buffer");
}
catch (Exception)
{
      MessageBox.Show("Erro desconhecido");
}



Repare que, agora, nós especificamos as exceções que cada bloco catch irá tratar caso ocorra algum tipo de erro dentro do bloco try. Nosso primeiro catch somente exceções do tipo IOException, que são exceções que ocorrem se houverem quaisquer erros de entrada e saída (como a falta do arquivo). Nosso segundo catch tratará somente exceções do tipo OutOfMemoryException, que são exceções que ocorrem geralmente quando falta memória para realizar a abertura e/ou leitura do arquivo. Nosso último bloco catch trata qualquer tipo de exceção, inclusive as anteriormente citadas; já que Exception especifica qualquer tipo de exceção que possa ocorrer. Porém, este último bloco só será executado caso não ocorram exceções do tipo IOException ou OutOfMemoryException. Isso ocorre porque as exceções IOException e OutOfMemoryException são mais “específicas” do que Exception, que é completamente genérica. Sendo assim, o C# irá primeiro ver se a exceção gerada cai em quaisquer blocos catch com exceções mais específicas. Caso a exceção gerada não caia na especificação de nenhum dos blocos try, e somente assim, o bloco com a exception genérica será executado. Você pode especificar um bloco try com quantos blocos catch forem necessários. Não há uma limitação de quantidade de blocos catch relacionados à um bloco try.

Além de poder especificar as exceções que serão tratadas dentro de cada bloco catch, você pode pegar a exceção que foi arremessada e obter detalhes desta, como por exemplo a mensagem que foi gerada pelo framework quando a exceção foi gerada. Repare mais uma vez no código abaixo.


try
{
      StreamReader stream = new StreamReader(@"C:\teste.txt");
      string linha;
      while((linha = stream.ReadLine()) != null)
      {
            // Tratamento da linha lida do arquivo texto
      }
}
catch (IOException)
{
      MessageBox.Show("O arquivo não existe na unidade C");
}
catch (OutOfMemoryException)
{
      MessageBox.Show("Sem memória para criação do buffer");
}
catch (Exception ex)
{
      MessageBox.Show("Erro desconhecido: " + ex.Message);
}

Repare no último bloco catch. Veja que especificamos uma variável à frente da especificação de Exception para o catch: a variável ex. O que estamos fazendo neste caso é pegar as informações geradas pela exceção e colocando-as dentro da variável ex, que representa uma exceção. A partir disto, podemos pegar várias informações sobre a Exception gerada, como por exemplo a mensagem gerada e a linha e respectiva classe que causaram o erro. Em nosso exemplo, usamos a variável ex para recuperar a mensagem gerada pela exceção. Repare na linha logo abaixo da especificação do bloco catch com a Exception: nós mostramos uma mensagem para o usuário através de MessageBox.Show(). Nós escrevemos uma mensagem genérica (“Erro desconhecido”) e logo após também exibimos a mensagem que foi gerada pela própria exceção, através do código “ex.Message”. Dessa maneira, podemos recuperar mais detalhes sobre as exceções que são geradas.

Programação defensiva

“Programação defensiva” é a iniciativa do programador de escrever seu código protegendo-o de erros de runtime. Veja o código do exemplo anterior com um trecho de programação defensiva:


try
{
      if (File.Exists(@"C:\teste.txt"))
      {
            StreamReader stream = new StreamReader(@"C:\teste.txt");
            string linha;
            while((linha = stream.ReadLine()) != null)
            {
                  // Tratamento da linha lida do arquivo texto
            }
      }
      else
      {
            MessageBox.Show("O arquivo não existe na unidade C");
      }
}
catch (IOException)
{
      MessageBox.Show("O arquivo não está acessível.");
}
catch (OutOfMemoryException)
{
      MessageBox.Show("Sem memória para criação do buffer");
}
catch (Exception ex)
{
      MessageBox.Show("Erro desconhecido: " + ex.Message);
}

O código acima usa o método File.Exists para verificar se o arquivo existe antes de tentar abri-lo, evitando que ocorra uma exceção de IOException caso o arquivo não exista.

O if não é uma estrutura de tratamento de erros porque não previne os erros de runtime; no entanto, ele permite técnicas de validação.

Você deve utilizar técnicas de programação defensiva de acordo com a frequência com que você acha que os problemas podem ocorrer no programa que se está criando. Se o erro de runtime for ocorrer menos de 25% das vezes em que o código for executado, o tratamento de erros é a forma mais eficiente de tratar o erro. O bloco try...catch é essencial se você tem mais do que uma condição para testar também, e se você quer privar os usuários de várias questões a serem respondidas para prevenir os erros. No entanto, se a estimativa de o erro ocorrer for maior de 25%, a programação defensiva é bem eficaz para diminuir a quantidade de exceções. 

 Não se preocupe: essa noção de “possibilidade” de ocorrer um erro você irá adquirir com o tempo e com a prática com o C#.

O ideal, porém, é o uso das duas: tanto da programação defensiva como dos blocos Try...Catch. 