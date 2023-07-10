using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmAgendaContatos : Form
    {
        private OperacaoEnum acao; 
        public frmAgendaContatos()
        {
            InitializeComponent();
        }

        private void frmAgendaContatos_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            lbxContatos.Items.AddRange(Manipulador.LerArquivo().ToArray());
            AlterarEstadoCampos(false);
        }

        private void AlterarBotoesSalvarECancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled =  estado;
        }

        public void AlterarBotoesIncluirAlterarExcluir(bool estado) 
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.INCLUIR;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadoCampos(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (acao == OperacaoEnum.INCLUIR)
            {
                Contato contato = new Contato
                {
                    Nome = txbNome.Text,
                    Email = txbEmail.Text,
                    NumeroTelefone = txbTelefone.Text
                };
                List<Contato> contatoList = new List<Contato>();
                foreach (Contato contatoDaList in lbxContatos.Items)
                {
                    contatoList.Add(contatoDaList);


                }
                contatoList.Add(contato);
                Manipulador.EscreverArquivo(contatoList);
            }
            else
            {
                Contato contato = new Contato
                {
                    Nome = txbNome.Text,
                    Email = txbEmail.Text,
                    NumeroTelefone = txbTelefone.Text
                };
                List<Contato> contatosList = new List<Contato>();
                foreach (Contato contatoDaList in lbxContatos.Items)
                {
                    contatosList.Add(contatoDaList);


                }
                int indice = lbxContatos.SelectedIndex;
                contatosList.RemoveAt(indice);
                contatosList.Insert(indice,contato);
                Manipulador.EscreverArquivo(contatosList);

            }
            CarregarListaContatos();
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            LimparCampos();
            AlterarEstadoCampos(false);
        }

        private void CarregarListaContatos()
        {
            lbxContatos.Items.Clear();
            lbxContatos.Items.AddRange(Manipulador.LerArquivo().ToArray());
            lbxContatos.SelectedIndex = 0;
        }
        private void LimparCampos()
        {
            txbNome.Text = "";
            txbEmail.Text = "";
            txbTelefone.Text = "";
        }
        private void AlterarEstadoCampos(bool estado)
        {
            txbNome.Enabled = estado;
            txbEmail.Enabled = estado;
            txbTelefone.Enabled = estado;
        }

        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contato contato = (Contato)lbxContatos.Items[lbxContatos.SelectedIndex];
            txbNome.Text = contato.Nome;
            txbEmail.Text = contato.Email;
            txbTelefone.Text = contato.NumeroTelefone;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.ALTERAR;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indiceExcluido = lbxContatos.SelectedIndex;
                lbxContatos.SelectedIndex = 0;
                lbxContatos.Items.RemoveAt(indiceExcluido);
                List<Contato> contatosList = new List<Contato>();
                foreach (Contato contato in lbxContatos.Items)
                {
                    contatosList.Add(contato);
                }
                Manipulador.EscreverArquivo(contatosList);
                
                CarregarListaContatos();
                LimparCampos();

            }
        }
    }
}
