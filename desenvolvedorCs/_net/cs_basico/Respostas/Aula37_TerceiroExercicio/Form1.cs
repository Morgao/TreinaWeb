using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula37_TerceiroExercicio.Utils;
using Aula37_TerceiroExercicio.Models;

namespace Aula37_TerceiroExercicio
{
    public partial class Form1 : Form
    {
        private OperacaoEnum acao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            CarregarListaProdutos();
            AlterarEstadoCamposProduto(false);
        }

        private void AlterarBotoesSalvarECancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }

        private void AlterarBotoesIncluirAlterarExcluir(bool estado)
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCamposProduto(true);
            acao = OperacaoEnum.ALTERAR;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadoCamposProduto(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto
            {
                Nome = txbNome.Text,
                Preco = Convert.ToDouble(txbPreco.Text),
                Quantidade = Convert.ToInt32(txbQuantidade.Text)
            };
            List<Produto> produtosList = new List<Produto>();
            foreach (Produto produtoDaLista in lbxProdutos.Items)
            {
                produtosList.Add(produtoDaLista);
            }
            if (acao == OperacaoEnum.INCLUIR)
            {
                produtosList.Add(produto);
            }
            else
            {
                int indice = lbxProdutos.SelectedIndex;
                produtosList.RemoveAt(indice);
                produtosList.Insert(indice, produto);
            }
            RepositoryProdutos.EscreverArquivo(produtosList);
            CarregarListaProdutos();
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            LimparCamposProduto();
            AlterarEstadoCamposProduto(false);
        }

        private void CarregarListaProdutos()
        {
            lbxProdutos.Items.Clear();
            lbxProdutos.Items.AddRange(RepositoryProdutos.LerArquivo().ToArray());
        }

        private void LimparCamposProduto()
        {
            txbNome.Text = "";
            txbPreco.Text = "";
            txbQuantidade.Text = "";
        }
        
        private void lbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = (Produto)lbxProdutos.Items[lbxProdutos.SelectedIndex];
            txbNome.Text = produto.Nome;
            txbPreco.Text = produto.Preco.ToString();
            txbQuantidade.Text = produto.Quantidade.ToString();

            AlterarEstadoCamposProduto(true);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indiceExcluido = lbxProdutos.SelectedIndex;
                lbxProdutos.SelectedIndex = 0;
                lbxProdutos.Items.RemoveAt(indiceExcluido);
                List<Produto> produtosList = new List<Produto>();
                foreach (Produto produto in lbxProdutos.Items)
                {
                    produtosList.Add(produto);
                }
                RepositoryProdutos.EscreverArquivo(produtosList);
                CarregarListaProdutos();
                LimparCamposProduto();
            }
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCamposProduto(true);
            acao = OperacaoEnum.INCLUIR;
        }

        private void AlterarEstadoCamposProduto(bool estado)
        {
            txbNome.Enabled = estado;
            txbPreco.Enabled = estado;
            txbQuantidade.Enabled = estado;
        }      

    }
}
