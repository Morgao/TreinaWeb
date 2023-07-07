using System;
namespace Itens
{
    public abstract class Item
    {
        public string Nome { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Item(String nome, int x, int y)
        {
            Nome = nome;
            X = x;
            Y = y;
        }
    }

}