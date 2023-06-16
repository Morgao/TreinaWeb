#include <stdio.h>
#include <stdlib.h>

void main () {

saudacao();
	int x = 25;
	int y = 12;
	int resultado = soma(x,y);
	printf("o valor da variavel resultado: %i ", resultado);

}

void saudacao () {
	printf("Boa tarde");
}


int soma (int num1, int num2) {
	
	return num1 + num2;

}