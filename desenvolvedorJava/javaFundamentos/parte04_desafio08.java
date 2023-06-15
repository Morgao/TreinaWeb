import java.util.*;

public class Programa
{
    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t=in.nextInt();
        for(int i=0;i<t;i++)
        {
            int a = in.nextInt();
            int b = in.nextInt();
            int n = in.nextInt();
            double total = 0;
            double aux = 0;
            aux = a + (1*b);
            
            System.out.print((int)aux);
            total = aux;
            double aux2 = 0;
           
            
           
            
            
            for (int j=1;j<n;j++){
                
                
               aux2 = Math.pow(2,j);
                total = + total + (aux2 * b);
               
                 System.out.print((int)total);
               
            }
            
            //Coloque seu código aqui

        }
        scanner.close();
    }
}