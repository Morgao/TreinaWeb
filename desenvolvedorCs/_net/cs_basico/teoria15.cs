Enum ou enumeradores

Tipos enumerados são listas de valores constantes cuja representação interna se dá através de números inteiros. Cada constante definida num tipo enumerado mapeia um número inteiro específico, que começa pelo valor inteiro zero (0). Entretanto, esse valor inicial pode ser sobrescrito quando assim especificado na declaração do tipo enumerado.

Veja a sintaxe de um enum:

[modificador] enum nome_enum
{
      elemento1,
      elemento2,
      //...
}
Os elementos da enumeração são, por padrão, do tipo int, mas podem ser de qualquer tipo integral – exceto char. O primeiro elemento é zero (0), o segundo elemento é 1, e assim sucessivamente. Por exemplo: 
public enum dia
{
      Domingo,
      Segunda,
      Terça,
      Quarta,
      Quinta,
      Sexta,
      Sábado
};



No exemplo acima o Domingo é 0, Segunda é 1, Terça é 2, etc.

Também podem ser definidos valores para cada elemento. Exemplo:


public enum dia
{
      Domingo = 7,
      Segunda = 15,
      Terça = 12,
      Quarta = 20,
      Quinta,
      Sexta,
      Sábado
};



Os elementos a que não foram atribuídos valores são incrementados com o valor do último elemento atribuído. No exemplo, os elementos têm os valores: Domingo = 7, Segunda = 15, Terça = 12, Quarta = 20.

Pode-se definir um tipo integral diferente de int. Exemplo:

Mas, para acessar os elementos, antes será preciso fazer uma conversão. Exemplo: 
int x = (int)dia.Domingo;


Essa é outra forma de converter elementos em C#. Ela é mais utilizada quando realizada entre tipos parecidos, como de int para long. Esse é um cast explícito.

Um determinado elemento de um tipo enumerado pode compartilhar o mesmo valor inteiro com outro elemento da lista. Exemplo:

public enum dia:short
{
      Domingo = 10,
      Segunda = 20,
      Terça = 15,
      Quarta = 60,
      Quinta = 30,
      Sexta = 25,
      Sabado = 45,
      dia_de_festa = Sábado,
      dia_de_descanso = Domingo
};
Note que foram adicionados dois elementos e atribuídos a eles os mesmos valores de Sabado e Domingo. Isso só foi possível porque os elementos Sabado e Domingo vêm antes dos dois novos elementos. Se o código fosse este: 

public enum dia:short
{
      dia_de_festa = Sábado,
      dia_de_descanso = Domingo,
      Domingo,
      Segunda,
      Terça,
      Quarta,
      Quinta,
      Sexta,
      Sábado
};
O compilador acusaria um erro. 