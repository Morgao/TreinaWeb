#include<stdio.h>

void main()
{

    int numero = 10;
    int *ponteiro = &numero;

    printf("Valor armazenado %i\n",*ponteiro);
    printf("O endereco de memoria e %p\n",ponteiro);

}