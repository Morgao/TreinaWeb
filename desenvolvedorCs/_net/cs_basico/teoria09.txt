Entendendo o conceito de “escopo”

Você viu que pode criar uma variável dentro de um método. A variável é criada no código que a define e outros trechos de códigos que vêm depois no mesmo método podem usá-la. Em outras palavras, uma variável pode ser usada só em certos lugares depois que tiver sido criada. Uma vez que o método terminou, a variável desaparece completamente.

Se uma variável pode ser usada em um local particular em um programa, ela parece estar no escopo daquele local. O escopo de uma variável é simplesmente a região do programa em que ela é utilizável, ou seja, onde ela é “enxergada”. O escopo se aplica a métodos como também a variáveis. O escopo de uma variável é ligado ao local da sua declaração e que a introduz no programa, como você aprenderá agora.

Criando escopo local com um método.

As chaves determinam onde começa e onde termina o corpo do método. Elas também determinam o escopo do método. Qualquer variável criada dentro do corpo do método faz parte do escopo do método. Essas variáveis são chamadas de variáveis locais porque são locais ao método onde são declaradas. Elas não podem ser usadas no escopo de outro método, por isso você não pode usar variáveis locais para armazenar informações entre métodos. Quando um método acaba a execução, ele finaliza as variáveis que criou.

Por exemplo:

class Exemplo
{
      void Metodo()
      {
            int variavel;
            //...
      }

      void OutroMetodo()
      {
            variavel = 42; // Isso gera um erro de compilação
      }
}

O erro mostrado acima ocorreu porque a variável foi criada dentro de um método diferente da qual está sendo usada. 


Criando escopo de classe com uma classe

As chaves determinam onde começa e onde termina o corpo da classe e determinam seu escopo. Assim sendo, qualquer variável que você criar dentro do corpo da classe (mas que não esteja dentro do método) faz parte de seu escopo. Em C#, o nome correto desse tipo de variável é campo. Em contraste às variáveis locais, você pode usar os campos para armazenar informações entre os métodos.

Por exemplo:


class Exemplo
{
      int campo;
      void Metodo()
      {
            campo = 42;
            //...
      }

      void OutroMetodo()
      {
            campo = 44;
      }
}




Perceba que a variável campo foi criada dentro da classe. Sendo assim, quaisquer métodos que estejam dentro da classe também (como o método Metodo() e o método OutroMetodo()) também são capazes de enxergar a variável campo, afinal, ela está no escopo da classe.

Em um método, você precisa declarar uma variável antes de usá-la. Porém, campos são diferentes: um método pode usar um campo antes de ser definido algum valor para ele: o campo estará com o valor padrão para o seu tipo de dado (por exemplo: tratando-se de um campo int, ele provavelmente estará com o valor 0, tratando-se de um campo string, ele estará com o valor “”).
