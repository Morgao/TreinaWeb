namespace CSharpCollections;

public class AulaDicionarios
{
    public static void main()
    {
        var alunos = new Dictionary<string, string>();
        alunos["123"] = "Cleyson";
        alunos["123"] = "Elton";

        imprimir(alunos);

        var aluno = "";
        alunos.TryGetValue("456", out aluno);
        Console.WriteLine(aluno);

        // Console.WriteLine(alunos.FirstOrDefault(aluno => aluno.Key == "456").Value);
    }

    private static void imprimir(Dictionary<string, string> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}