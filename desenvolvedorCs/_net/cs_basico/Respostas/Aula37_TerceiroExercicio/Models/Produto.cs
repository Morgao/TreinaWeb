using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula37_TerceiroExercicio.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome = "", double preco = 0.0, int quantidade = 0)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - Qdt: {2}", this.Nome, this.Preco.ToString("C"), this.Quantidade);
        }
    }
}
