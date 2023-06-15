import java.util.*;
import java.io.*;
import java.lang.*;

public class Programa{

    public static void main(String []argh)
    {
        Scanner scann = new Scanner(System.in);
        int t=scann.nextInt();

        for(int i=0;i<t;i++)
        {

            try
            {
                long x = scann.nextLong();
                
                System.out.println(x+" pode ser armazenado nos tipos:");
int aux = 0;
if((x>= Math.pow(-2,7)) && (x<= (Math.pow(2,7) -1))){
	System.out.println("byte");
	aux = +1;
}
if((x>= Math.pow(-2,15)) && (x<= (Math.pow(2,15) -1))){
	System.out.println("short");
	aux = +1;
}
if((x>= Math.pow(-2,31)) && (x<= (Math.pow(2,31) -1))){
	System.out.println("int");
	aux = +1;
}
if((x>= Math.pow(-2,63)) && (x<= (Math.pow(2,63) -1))){
	System.out.println("long");
	aux = +1;
}
if(aux == 0){
	System.out.println("N não pode ser armazenado em nenhum tipo numérico inteiro");
}
                //Complete o código

            }
            catch(Exception e)
            {
                System.out.println(scann.next()+" não pode ser armazenado em nenhum tipo numérico inteiro.");
            }

        }
    }
}