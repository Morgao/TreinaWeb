#include <stdio.h>
#include <stdlib.h>


void main () {
	
	int numeros[3][3] = {
	2,4,
	6,8,
	10,12,
	18,20, 9
};
	int i = 0;
	int j = 0;
	for(i = 0; i < 3;i++){
		for(j = 0; j < 3;j++){
		printf("Matriz: %i\n", numeros[i][j]);
		}
	}
	
	
}
	