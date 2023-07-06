Namespaces

Para resolver o problema de desorganização de funções, existente na época do antigo VB, o .NET Framework criou os namespaces (espaço de nomes). Este assunto foi introduzido no tópico de classe do .NET, no início do curso.

Para utilizar os namespaces e classes definidos pelo .NET Framework, primeiro deve-se importar o espaço de nome que contém a classe. Assim, indica-se em qual espaço de nome está a classe, ou a função, que se quer executar. No C# isso é feito com a instrução using. É possível também utilizar os membros de uma classe sem importar o espaço de nome. Neste caso, utiliza-se o nome qualificado completo. Por exemplo:

using System;

namespace Classes
{
      class PrimeiraClasse
      {
            void Main()
            {
                  Console.WriteLine("Olá Mundo!");
            }
      }
}
Ou 

namespace Classes
{
      class PrimeiraClasse
      {
            void Main()
            {
                  System.Console.WriteLine("Olá Mundo!");
            }
      }
}



O primeiro exemplo mostra que foi utilizada a instrução using para importar o namespace System para utilizar a classe Console. Já no segundo exemplo o namespace não foi importado, mas utilizado o nome completo para utilizar a função.
Dica

Evite utilizar nomes completos para utilizar as funções, pois isso diminui a legibilidade do código.
