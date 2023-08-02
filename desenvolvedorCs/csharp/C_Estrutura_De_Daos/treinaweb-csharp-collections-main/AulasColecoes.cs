namespace CSharpCollections;

public class AulasColecoes
{
    public static void main()
    {
        // var alunos = new HashSet<string>();
        // alunos.Add("Cleyson");
        // alunos.Add("Sara");
        // alunos.Add("Elton");
        // alunos.Add("Sara");

        // imprimir(alunos);

        // Console.WriteLine(alunos.First(aluno => aluno.StartsWith("S")));

        var alunos = new HashSet<Aluno>();
        alunos.Add(new Aluno("Cleyson", "Lima"));
        alunos.Add(new Aluno("Elton", "Fonseca"));
        alunos.Add(new Aluno("Cleyson", "Lima"));
        imprimir(alunos);

        Console.WriteLine(new Aluno("Elton", "Fonseca").GetHashCode());
        Console.WriteLine(new Aluno("Cleyson", "Lima").GetHashCode());
        Console.WriteLine(new Aluno("Cleyson", "Lima").GetHashCode());
    }

    private static void imprimir(HashSet<Aluno> set)
    {
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
}

public class Aluno
{
    public Aluno(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public override string ToString()
    {
        return $"{Nome} {Sobrenome}";
    }

    public override bool Equals(object? obj)
    {
        var aluno = obj as Aluno;
        if (aluno is null)
        {
            return false;
        }
        return $"{Nome} {Sobrenome}".Equals($"{aluno.Nome} {aluno.Sobrenome}");
    }

    public override int GetHashCode()
    {
        return $"{Nome} {Sobrenome}".GetHashCode();
    }
}