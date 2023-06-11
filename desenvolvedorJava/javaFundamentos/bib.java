saida
System.out.println(""); // escreve e pula linha
System.out.print(""); // nao quebra linha
 "\n" tambem pula linha
"\r" tambem pula linhas no windows

leitura // Scanner // import java.util.Scanner; // nao e global.
scanner no out, no in, no err
variaveis no java inicia com letra minuscula 
classe com letra maiuscula
Scanner scanner = new Scanner(System.in); // ctrl espaco
Scanner scanner = new Scanner(System.out);
System.out.print("Digite seu nome: ");
String nome = scanner.nextLine();
System.out.println(nome);
scanner.close(); // fechar conexao do csacner

int numero1 = Integer.parseInt(scanner.nextLine()); // convertendo string para "caste" inteiro


int numero1 = scanner.nextInt(); // 2 manerira de converter string em inteiro

char operacao = scanner.nextLine(); // entre aspas simples um unico caracter
string operacao = scanner.nextLine(); // entra aspas duplas conjunto de caracters

char operacao = scanner.next();
nextLine - next retorna tbm uma string
char operacao = scanner.next().charAt(index); // primeiro indice com indice 0
char operacao = scanner.next().charAt(0); // primeiro indice com indice 0
scanner.next(); // o espaco para terminar a captura
scanner.nextLine(); // depois do enter terminar a captura

numero dentro da string
meta caracter
int = %d
char = %c

System.out.println(String.format("voce quer fazer a operacao %d %c %d",nome1, operacao, nome2)); //interpolacao