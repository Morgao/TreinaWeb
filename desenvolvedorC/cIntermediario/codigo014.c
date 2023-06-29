#include <stdio.h>
#include <stdlib.h>

struct NO{
  int numero;
  struct NO *proximo;
};
typedef struct NO no;

no *RETIRADA(no *PILHA)
{
  if(PILHA->proximo == NULL){
    printf("PILHA ja esta vazia\n");
  }else{
    no *ultimo = PILHA->proximo;
    no *penultimo = PILHA;

    while(ultimo->proximo != NULL)
        {
            penultimo = ultimo;
            ultimo = ultimo->proximo;
        }
        penultimo->proximo = NULL;
  }

}


void OPCOES(no *PILHA, int op)
{
  no *temp;
  switch(op){
    case 0:
      LIBERACAO(PILHA);
      break;

    case 1:
        INSERIR(PILHA);
      break;

    case 2:
        temp= RETIRADA(PILHA);
      break;

    case 3:
        EXIBIR(PILHA);
      break;

    default:
      printf("Comando invalido\n\n");
  }
}


int vazia(no *PILHA)
{
  if(PILHA->proximo == NULL)
    return 1;
  else
    return 0;
}

no *ALOCACAO()
{
  no *novo= malloc(sizeof(no));
  if(!novo){
    printf("Sem memoria disponivel!\n");
    exit(1);
  }else{
    printf("Novo elemento na PILHA: "); scanf("%d", &novo->numero);
    return novo;
  }
}

void INSERIR(no *PILHA)
{
  no *novo=ALOCACAO();
  novo->proximo = NULL;

  if(vazia(PILHA))
    PILHA->proximo=novo;
  else{
    no *temp = PILHA->proximo;

    while(temp->proximo != NULL)
      temp = temp->proximo;

    temp->proximo = novo;
  }

}

void EXIBIR(no *PILHA)
{
  if(vazia(PILHA)){
    printf("PILHA vazia!\n\n");
    return ;
  }

  no *temp;
  temp = PILHA->proximo;
  printf("\nPILHA :");
  while( temp != NULL){
    printf("%5d", temp->numero);
    temp = temp->proximo;
  }

  printf("\n\n");
}

void LIBERACAO(no *PILHA)
{
  if(!vazia(PILHA)){
    no *proxNode,
        *atual;

    atual = PILHA->proximo;
    while(atual != NULL){
      proxNode = atual->proximo;
      free(atual);
      atual = proxNode;
    }
  }
}


int main(void)
{
    int opt;

  no *PILHA = malloc(sizeof(no));
  if(!PILHA){
    printf("Sem memoria!\n");
    exit(1);
  }else{
    PILHA->proximo = NULL;

  do{

        printf("Opcoes\n");
        printf("0 - Sair\n");
        printf("1 - Inserir\n");
        printf("2 - Retirar\n");
        printf("3 - Exibir\n");
        printf("Opcao: ");
        scanf("%d", &opt);

    OPCOES(PILHA,opt);
  }while(opt);

  free(PILHA);
  return 0;
  }
}