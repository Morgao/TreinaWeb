#include <stdio.h>
#include <stdlib.h>

void main () {

saudacao();
	int resultado = soma();
	printf("o valor da variavel resultado: %i ", resultado);

}

void saudacao () {
	printf("Boa tarde");
}


int soma () {
	int num1, num2;
	num1 = 30;
	num2 = 15;
	return num1 + num2;

}