namespace CSharpCollections;

public class AulasListas
{
    public static void main()
    {
        var alunos = new List<string>() { "Cleyson", "Elton", "Wesley", "Ana", "Ariel" };
        Console.WriteLine(alunos.IndexOf("Cleyson"));
        Console.WriteLine(alunos.IndexOf("Sara"));

        Console.WriteLine("-------------------------------");

        imprimir(alunos);
        alunos.Add("Sara");
        imprimir(alunos);

        Console.WriteLine("-------------------------------");

        alunos.Insert(2, "Amauri");
        imprimir(alunos);

        Console.WriteLine("-------------------------------");

        alunos.RemoveAt(2);
        imprimir(alunos);

        Console.WriteLine("-------------------------------");

        alunos.AddRange(new List<string> { "Sara", "Amauri", "Felipe" });
        imprimir(alunos);

        Console.WriteLine("-------------------------------");

        Console.WriteLine(alunos.Exists(aluno => aluno.StartsWith("C")));

        Console.WriteLine("-------------------------------");
        Console.WriteLine(alunos.Find(aluno => aluno.StartsWith("C")));

        Console.WriteLine("-------------------------------");
        var alunos2 = alunos.GetRange(0, alunos.Count);
        imprimir(alunos2);
    }

    private static void imprimir(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}