Operadores aritméticos

O C# suporta os símbolos aritméticos, conhecidos para as operações básicas:

Operador
	

Nome
	

Uso

+
	

Adição
	

Executa a operação de adição (soma) entre tipos numéricos. Também indica concatenação (junção) de strings

-
	

Subtração
	

Efetua a operação de subtração (diferença) entre tipos numéricos

*
	

Multiplicação
	

Efetua a operação de multiplicação entre tipos numéricos

/
	

Divisão
	

Efetua a operação de divisão entre tipos numéricos

%
	

Módulo
	

Devolve o resto de uma operação de divisão

Dos cinco operadores acima, os três primeiros trabalham de maneira conhecida (adição, subtração e multiplicação). Já o operador de divisão (/) trabalha de maneira diferente na divisão de um inteiro; por exemplo, ao dividir 11 por 2 usando esse operador (sendo 11 um inteiro) o resto da divisão é descartado, pois os inteiros não aceitam números fracionários. Ou seja: o resultado seria 5. Já o operador de módulo (%) tem como única função pegar o resto de uma divisão; no mesmo exemplo, ao dividir 11 por 2 usando o operador % (modulo) o resultado seria 1, já que é o resto da divisão.

Veja outro exemplo:


long salario;
salario = 500 * 20;


A expressão acima multiplica 500 por 20 e armazena o resultado na variável salario.

Entretanto, você não pode usar os operadores para qualquer tipo de dado. Os operadores matemáticos, por exemplo, só podem ser usados para os tipos char, int, long, float, double e decimal. Eles não podem ser usados para string e bool. Exemplo:

Console.WriteLine("Londrina" – "São Paulo");

Isso irá gerar um erro porque não se pode subtrair uma string de outra. 

Console.WriteLine("43" – "11");

Isso também irá gerar um erro porque valores entre aspas são sempre strings. Para efetuar a subtração o correto é: 

Console.WriteLine(43 – 11);
Precedência de operador

Alguns operadores aritméticos têm precedência sobre outros, veja:

int X = 25 – 7 * 2;



A expressão acima tem duas respostas, dependendo do modo que se faça a conta.

Por exemplo:

    25 - 7 = 18, 18 * 2 = 36, x = 36.
    7*2 = 14, 25-14 = 11, x = 11.

Qual é a resposta correta?

Neste caso, a segunda; ou seja: x = 11. O operador de multiplicação * tem precedência sobre o operador de subtração -; assim, o cálculo de multiplicação é feito primeiro.

Mas e se quiséssemos que a subtração fosse feita primeiro?

Simples. Para resolver esse "problema", basta usar os parênteses:


int x = (25 – 7) * 2;



Agora sim o resultado correto seria 36, pois o que está entre parênteses é calculado primeiro e, depois, com o resultado desse cálculo, é feito o resto da expressão. Perceba que a ordem de precedência altera o valor do resultado; por isso, deve-se ter atenção à precedência. Os operadores multiplicativos (*, /, %) têm precedência sobre os aditivos (+, -). Confira a tabela abaixo:

Operador
	

Descrição

(expressão)
	

Controle de precedência

objeto.membro
	

Acesso a membro do objeto

método (argumento1, ..., argumentoN)
	

Enumeração de argumentos

array[índice]
	

Elemento de um array

var++, var--
	

Operadores de incremento e decremento

new
	

Criação do objeto

typeof/sizeof
	

Retorna, respectivamente, tipo e tamanho de uma variável

+, -
	

Especificam, respectivamente, números positivos e negativos

!
	

Operador de negação (not) lógica

~
	

Complemento bit a bit

++var, --var
	

Operadores, respectivamente, de pré-incremento e pré-decremento

(conversão) var
	

Conversão de tipos de dados

*,/
	

Operadores de, respectivamente, multiplicação e divisão

%
	

Operador de módulo (resto) da divisão

+, -
	

Operadores de, respectivamente, adição e subtração

<, <=, >=, >, is, ==, !=
	

Operadores de comparação

&
	

Operador AND a nível de bits

^
	

Operador XOR a nível de bits

|
	

Operador OR a nível de bits

&&, ||
	

Operadores lógicos, respectivamente, de AND e OR

? :
	

Operador ternário

=, *=, /=, %=, +=, -=, <<=, >>=
	

&=, ^=, |=
	

Alguns operadores descritos acima ainda não foram demonstrados, mas não se preocupe porque serão explicados ao longo do curso.


Operadores reduzidos

Também há em C# uma série de operadores reduzidos para executar tarefas. Exemplo:

int i = 0;
i = i + 2;
A instrução pode ser reduzida utilizando-se +=: 

int i = 0;
i += 2;

As duas instruções acima são equivalentes e este conceito pode ser utilizado por qualquer operador aritmético. 

Incremento e decremento

Pode-se reduzir os operados para evitar digitá-los novamente, tornando o código mais limpo. Quando o valor que se deseja somar ou subtrair for 1, pode-se reduzir ainda mais usando ++ ou --. Exemplo:

contador ++;


ou

contador --;
é a mesma coisa que: 
contador += 1;
ou 
contador -= 1;
ou 
contador = contador + 1;
ou 
contador = contador – 1;
A diferença é que com ++ o cálculo é feito mais rápido que os demais, sendo muito utilizado nos laços (tratado mais adiante). 