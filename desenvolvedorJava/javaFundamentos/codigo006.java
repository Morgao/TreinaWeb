package br.com.treinaweb.main;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		/*
		 * System.out.print("Digite o primeiro numero: "); int numero1 =
		 * scanner.nextInt(); System.out.println("Digite a operacao: "); char operacao =
		 * scanner.next().charAt(0); System.out.println(numero1);
		 */
		System.out.print("Digite uma mensagem: ");
		String mensagem = scanner.nextLine();
		// pega os dados ate usar o enter
		System.out.println(mensagem);
		scanner.close();
	}

}
