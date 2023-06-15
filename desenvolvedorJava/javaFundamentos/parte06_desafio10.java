import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Programa {

    public static void main(String[] args) {
Scanner scanner = new Scanner(System.in);
ArrayList<String> historico = new ArrayList<String>();
 int i = 1;
while (scanner.hasNextLine()) {
  
           
             String linha = scanner.nextLine();
		String entradaDoHistorico = String.format("%d %s",i,linha);
		historico.add(entradaDoHistorico);
		i++;
        }
		historico.forEach(itemHistorico -> System.out.println(itemHistorico));

    }
}