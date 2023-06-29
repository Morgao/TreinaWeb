#include <stdio.h>
#include <stdlib.h>

typedef struct Cao {
  char *nome;
  int idade;
  char *raca;
}dog;

void Exibir(dog c)
{
    printf("Nome : %s\n",c.nome);
    printf("Idade : %d\n",c.idade);
    printf("Raca : %s\n",c.raca);
}

int main()
{
    dog d1 = {"fifi",2,"poodle"};
    Exibir(d1);

  return 0;
}