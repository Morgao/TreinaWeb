namespace CSharpCollections;

public class AulaArrays
{
    public static void main()
    {
        var aluno1 = "Cleyson";
        var aluno2 = "Elton";
        var alunos = new string[] { aluno1, aluno2 };

        imprimir(alunos);

        Console.WriteLine("-------------------------");
        aluno1 = "Wesley";
        imprimir(alunos);

        Console.WriteLine("-------------------------");
        var alunos2 = alunos;
        imprimir(alunos2);
        alunos[0] = "Wesley";
        imprimir(alunos2);

        Console.WriteLine("-------------------------");
        var alunosCopia = new string[2];
        Array.Copy(alunos, alunosCopia, alunos.Length);
        imprimir(alunosCopia);
        alunos[1] = "Cleyson";
        imprimir(alunosCopia);
    }

    private static void imprimir(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}