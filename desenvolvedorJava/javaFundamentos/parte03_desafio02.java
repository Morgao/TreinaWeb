Scanner scanner = new Scanner(System.in);
        String nome = scanner.nextLine();
		int numero1 = Integer.parseInt(scanner.nextLine());
		System.out.println(String.format("%s \n %d", nome, numero1));
	        
        scanner.close();