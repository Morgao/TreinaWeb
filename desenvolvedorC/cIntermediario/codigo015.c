#include <stdio.h>
#include <stdlib.h>

struct NO
{
    struct NO *direita;
    struct NO *esquerda;
    char letra;
};

typedef struct NO no;

no* CriarVazia(void)
{
    return NULL;
}

no* Criar(char c, no* direito, no* esquerdo)
{
    no* aux = malloc(sizeof(no));
    aux->letra = c;
    aux->direita = direito;
    aux->esquerda = esquerdo;
    return aux;
}

int Vazia(no* p)
{
    return p==NULL;
}

no* Libera(no* val)
{
    if(!Vazia(val))
    {
        Libera(val->esquerda);
        Libera(val->direita);
        free(val);
    }
    return NULL;
}

void Imprimir(no* val)
{
    if(!Vazia(val))
    {
        printf("%c",val->letra);
        Imprimir(val->direita);
        Imprimir(val->esquerda);
    }else{
        printf("Arvore vazia\n");
    }
}

int main()
{
    no* v1= CriarVazia();

    Imprimir(v1);

    return 0;
}