public delegate int ExecutarCalculo(int a, int b);

public int Somar(int a, int b)
{
     return a + b;
}

public int Subtrair(int a, int b)
{
     return a – b;
}

ExecutarCalculo somarDelegate = new ExecutarCalculo(Somar);
ExecutarCalculo subtrairDelegate = new ExecutarCalculo(Subtrair);
int resultadoSoma = somarDelegate(2, 1); //resultadoSoma será 3
int resultadoSubtracao = subtrairDelegate(2, 1); //resultadoSubtracao será 1