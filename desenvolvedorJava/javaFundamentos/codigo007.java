package br.com.treinaweb.main;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Digite o primeiro numero: "); 
		int numero1 = scanner.nextInt(); 
		System.out.println("Digite a operacao: "); 
		char operacao = scanner.next().charAt(0);
		System.out.println("Digite o segundo numero: ");
		int numero2 = scanner.nextInt();
		System.out.println(String.format("voce quer fazer a operacao %d %c %d",numero1, operacao, numero2));
	
		 
	
		scanner.close();
	}

}
