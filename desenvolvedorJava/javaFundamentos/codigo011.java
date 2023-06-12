package br.com.treinaweb.main;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {
	static int resultado;

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int acao = 1; // 0 sair - 1 operacao 2 historico
		ArrayList<String> historico = new ArrayList<String>();
		while (acao > 0) {
			if (acao == 1) {
			System.out.println(" === Operacao Matematica === ");

			System.out.print("Digite o primeiro numero: ");
			int numero1 = scanner.nextInt();
			System.out.print("Digite a operacao: ");
			char operacao = scanner.next().charAt(0);
			System.out.print("Digite o segundo numero: ");
			int numero2 = scanner.nextInt();

			switch (operacao) {
			case '+':
				resultado = numero1 + numero2;
				break;
			case '-':
				resultado = numero1 - numero2;
				break;
			case '*':
				resultado = numero1 * numero2;
				break;
			case '/':
				resultado = numero1 / numero2;
				break;
			default:
				System.out.println("Operacao invalida!");
				break;
			}
			
			String entradaDoHistorico = String.format("o resultado de %d %c %d = %d", numero1, operacao, numero2,
					resultado);
			historico.add(entradaDoHistorico);
			System.out.println(entradaDoHistorico);
			}else if (acao == 2) {
				System.out.println(" === Historico === ");
				System.out.println(String.format(" Você Já fez %d operações: ", historico.size()));
				
				historico.forEach(itemHistorico -> System.out.println(itemHistorico));
			}
			System.out.println(" === O que você deseja fazer? ===");
			System.out.println("[1] Realizar Operacao Matemáica ");
			System.out.println("[2 Visualizar o Histórico ");
			System.out.println("[0]  Sair ");
			System.out.println("Sua Opcção: ");
			acao = scanner.nextInt();
			
			
		}
		scanner.close();

	}
}
