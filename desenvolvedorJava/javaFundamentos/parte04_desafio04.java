if ((N % 2 == 0) && (N < 10)){
	        System.out.println("Não é estranho");
	    }
		else if ((N % 2 == 0) && (N >= 10) && (N <= 20 )){
	        System.out.println("Estranho");
	    }
	    else if ((N % 2 == 0) && (N > 20)){
	        System.out.println("Não é estranho");
	    }
	    else if (N % 2 != 0){
	        System.out.println("Estranho");
	    }