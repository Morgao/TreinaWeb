#include <stdio.h>
#include <stdlib.h>


void main () {
	
	qualquer();
	qualquer();
	qualquer();
	qualquer();
}

void qualquer () {
	static int numero = 0;
	numero = numero +1;
	printf("zero2 : %i", numero);
}