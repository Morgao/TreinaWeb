namespace CSharpCollections;

public class AulaFilas
{
    public static void main()
    {
        var fila = new Queue<string>();

        // [Cleyson]
        fila.Enqueue("Cleyson");

        // [Cleyson], [Elton]
        fila.Enqueue("Elton");

        // [Cleyson], [Elton], [Ariel]
        fila.Enqueue("Ariel");

        // [Elton], [Ariel]
        fila.Dequeue();

        // [Ariel]
        fila.Dequeue();

        fila.Dequeue();
        fila.Dequeue();

        imprimir(fila);
    }

    private static void imprimir(Queue<string> fila)
    {
        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }
    }
}