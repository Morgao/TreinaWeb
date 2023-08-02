namespace CSharpCollections;

public class AulaListasLigadas
{
    public static void main()
    {
        // 1 <-> 2 <-> 3 <-> 4 <-> 5
        var listaLigada = new LinkedList<string>();

        // [Primeira posição] -> []
        var node1 = listaLigada.AddFirst("Primeira posição");

        // [Primeira posição] <-> [Segunda posição] -> []
        var node2 = listaLigada.AddAfter(node1, "Segunda posição");

        // [Primeira posição] <-> [Terceira posição] <-> [Segunda posição] -> []
        var node3 = listaLigada.AddBefore(node2, "Terceira posição");

        // [Primeira posição] <-> [Terceira posição] <-> [Segunda posição] <-> [Quarta posição]
        var node4 = listaLigada.AddLast("Quarta posição");

        imprimir(listaLigada);

        Console.WriteLine("---------------------------");

        // [Terceira posição] <-> [Segunda posição] <-> [Quarta posição]
        listaLigada.RemoveFirst();
        imprimir(listaLigada);

        Console.WriteLine("---------------------------");

        // [Terceira posição] <-> [Segunda posição]
        listaLigada.RemoveLast();
        imprimir(listaLigada);

        Console.WriteLine("---------------------------");

        // [Segunda posição]
        listaLigada.Remove("Terceira posição");
        imprimir(listaLigada);

        Console.WriteLine("---------------------------");

        Console.WriteLine(listaLigada.Contains("Segunda posição"));

        Console.WriteLine("---------------------------");

        Console.WriteLine(listaLigada.Find("Primeira posição")?.Value);
    }

    private static void imprimir(LinkedList<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}