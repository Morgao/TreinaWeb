using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula37_TerceiroExercicio.Models;

namespace Aula37_TerceiroExercicio.Utils
{
    public class RepositoryProdutos
    {
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "produtos.txt";

        public static List<Produto> LerArquivo()
        {
            List<Produto> produtosList = new List<Produto>();
            if (File.Exists(@EnderecoArquivo))
            {
                using (StreamReader sr = File.OpenText(@EnderecoArquivo))
                {
                    while (sr.Peek() >= 0)
                    {
                        string linha = sr.ReadLine();
                        string[] linhaComSplit = linha.Split(';');
                        if (linhaComSplit.Count() == 3)
                        {
                            Produto produto = new Produto();
                            produto.Nome = linhaComSplit[0];
                            produto.Preco = Convert.ToDouble(linhaComSplit[1]);
                            produto.Quantidade = Convert.ToInt32(linhaComSplit[2]);
                            produtosList.Add(produto);
                        }
                    }
                }
            }
            return produtosList;
        }

        public static void EscreverArquivo(List<Produto> produtosList)
        {
            using (StreamWriter sw = new StreamWriter(@EnderecoArquivo, false))
            {
                foreach (Produto produto in produtosList)
                {
                    string linha = string.Format("{0};{1};{2}", produto.Nome, produto.Preco, produto.Quantidade);
                    sw.WriteLine(linha);
                }
                sw.Flush();
            }
        }
    }
}
