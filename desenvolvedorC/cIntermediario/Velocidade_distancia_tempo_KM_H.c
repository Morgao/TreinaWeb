#include<stdio.h>

void main()
{
    int Escolha;

Retorno:
    printf("\n\n\n\n");
    Menu();

        do{
printf("Digite um numero inteiro valido\n");
            scanf("%i",&Escolha);

        }while(Escolha > 5);


        switch(Escolha)
        {

        case 0:
            printf("\nTchau\n");
            exit(1);
            break;

        case 1:
            printf("\nDigite um valor para Distancia e outro para velocidade\n");
            Tempo();
            goto Retorno;
            break;

        case 2:
            printf("\nDigite um valor para velocidade e outro para o tempo\n");
            Distancia();
            goto Retorno;
            break;

        case 3:
            printf("\nDigite um valor para Distancia e outro para o tempo\n");
            Velocidade();
            goto Retorno;
            break;
        case 4:
            printf("\nDigite o valor em Horas para conversao em Minutos\n");
            HorasMinutos();
            goto Retorno;
            break;
        case 5:
            printf("\nDigite o valor em Km para converter para MS\n");
            KMparaMS();
            goto Retorno;
            break;

           default:
            printf("Escolha uma opcao valida");
            goto Retorno;
            break;
        }

}

void Menu()
{
    int i;

    for(i=0; i<30; i++)
    {
       printf("=");
    }

    printf("\n\nEscolha uma das opcoes abaixo:\n\n");

    printf("(1) Tempo gasto no trajeto:\n");
    printf("(2) Distancia percorida no trajeto:\n");
    printf("(3) Velocidade media:\n");
    printf("(4) Horas para minuto:\n");
    printf("(5) Velocidade em K/M para Velocidade em M/S:\n");


    for(i=0; i<30; i++)
    {
       printf("=");
    }
}





void Tempo()
{
    int x,y;
    scanf("%i",&x);
    scanf("%i",&y);



        float Resultado = (float)x/y;
        printf("\ o tempó e e : %.0f Horas \n\n",Resultado);



}

void Distancia()
{
    int x,y;
    scanf("%i",&x);
    scanf("%i",&y);


        float Resultado = (float)x/y;
        printf("\n a distancia e : %.0f KM \n\n",Resultado);


    }

void Velocidade()
{
    int x,y;
    scanf("%i",&x);
    scanf("%i",&y);


        float Resultado = (float)(x/y);
        printf("\n A velocidade e : %.0f KM/H \n\n",Resultado);


    }

void HorasMinutos()
{
    int x;
    scanf("%i",&x);


        float Resultado = (float)(x/60);
        printf("\n A hora em minutos e : %.2f KM/H \n\n",Resultado);


}

void KMparaMS()
{
    int x;
    scanf("%i",&x);


        float Resultado = (float)(x/3.16);
        printf("\n A velocidade em m/s : %.2f KM/H \n\n",Resultado);


}

