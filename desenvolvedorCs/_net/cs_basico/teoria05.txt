Introdução às Strings

Uma string (ou sequência de caracteres) é uma matriz de caracteres. Uma sequência de caracteres literal é declarada usando aspas, como mostrado no exemplo a seguir:

string s = "Texto";
Console.WriteLine(s);

Você pode concatenar sequências, como este: 

string s = "Texto";
string s2 = "do Curso";
Console.WriteLine(s + " " + s2);

No exemplo abaixo, estamos obtendo, a partir da posição zero, 3 caracteres: 

string s = "Texto";
string s2 = s.Substring(0,3);
Console.WriteLine(s2);



O resultado será “Tex”.

Strings são imutáveis, significando que elas não podem ser alteradas uma vez que tenha sido criada. Métodos que atuam em strings realmente retornam novas strings.
Caracteres de escape

Caracteres de escape, como "\n" (nova linha) e "\t" (tabulação) podem ser incluídos em sequências. Por exemplo:

string s = "ab\ncd";
Console.WriteLine(s);


Teremos como resultado:

Se você desejar incluir uma barra dentro da string, ela deve ser precedida com outra barra invertida. Como no exemplo:

string s = "ab\\ncd";
Console.WriteLine(s);
Repare que, nesse caso, o caractere de escape (\n) acaba sendo anulado pela outra barra que foi acrescentada (“ab\\ncd”).

O símbolo @ ( Arroba )

O @ diz para o construtor da String ignorar caracteres de escape e quebras de linha. Por exemplo:

string s = @"ab\ncd";
Console.WriteLine(s);


Resultado:

Repare que, apesar de haver o caractere de escape (“\n”), ele é ignorado e tratado como uma string comum, graças ao “@”.
