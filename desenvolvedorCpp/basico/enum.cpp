Enum

As constantes enumeradas ou enum são listas de valores constantes cuja representação interna se dá através de números inteiros.

A estrutura dessa constante é:

enum NomedasConstantes
{
  Valor1,
  Valor2,
  ValorN
};
Pronto fazendo isso já declaramos nossa constante enumerada, agora para acessar os valores que existem nessa constante é muito fácil, basta termos em mente que a coleção de valores adicionados ao enum são enumeradas a partir do zero, então, se eu quiser acessar o valor segunda preciso na realidade acessar o valor zero do enum que estou trabalhando veja um exemplo:

#include<iostream>

using namespace std;


int main()
{
   enum Semana
   {
       segunda,
       terca,
       quarta,
       quinta,
       sexta,
       sabado,
       domingo
   };

   Semana d;

   d = Semana(0);

   if(d == segunda)
   {
        cout << "Hoje e segunda feira";
   }

    return 0;
}

No código acima estamos mantendo a estrutura básica de um código em C++ com a diferença de estarmos adicionando um enum chamado Semana dentro da função main().

Esse enum tem todos os sete dias da semana então, para acessar qualquer um desses dias basta criar uma variável do tipo Semana com um nome qualquer no nosso caso o nome é “ d ”.

Depois atribuímos a d o valor contido em Semana(0) (segunda), feito isso criamos uma condição que verifica de o valor de d é igual ao valor de segunda que se encontra dentro de enum.

Tendo uma resposta positiva exibimos uma mensagem que confirma que é segunda.

Um detalhe importante que precisamos falar sobre enum é que um enum por default começa sua contagem do zero “ 0 ”, mas isso não precisa ser sempre assim o programador tem total autonomia para mudar o valor inicial da contagem veja um exemplo:

enum Exemplo
{
  Valor1 = 5,
  Valor2,
  ValorN
};
No exemplo acima informamos ao compilador que a contagem inicia no valor 5 isso significa que os próximos valores de enum continuarão a contagem a partir dai sendo o próximo valor o 6, 7, 8, etc...