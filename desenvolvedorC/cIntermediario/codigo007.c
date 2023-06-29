#include <stdio.h>
#include <stdlib.h>

    struct
    {
        int Numero;
    }Loja1,Loja2;

int main()
{
    Loja1.Numero = 20;

    Loja2 = Loja1;

    printf("%d",Loja1.Numero);
    printf("\n");
    printf("%d",Loja2.Numero);
    printf("\n");

    return 0;
}