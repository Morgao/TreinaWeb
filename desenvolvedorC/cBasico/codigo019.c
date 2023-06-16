#include<stdio.h>

void main()
{

    int x[] = {0,1, 2, 3, 4, 5, 6,7,8,9,10};
    int *ponteiro = &x;
    int i;
    
    int y[] = {4,24,8,10,12,14,16,18,20,6,2};
    int *ponteiro2 = &y;
    int j;
    
    
    for (i = 0; i < 11; i++)
    {
        printf("%i\n", *(ponteiro++));
    }
    
    for (j = 0; j < 11; j++)
	{
		printf("%i\n", *(ponteiro2++))
;    	
	}
    
    

}