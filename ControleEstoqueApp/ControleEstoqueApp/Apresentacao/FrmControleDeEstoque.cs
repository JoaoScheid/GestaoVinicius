using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Servicos;
using System;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    public partial class FrmControleDeEstoque : Form
    {
        private int _produtoIdSelecionado;
        private readonly ProdutoServico _produtoServico;

        public FrmControleDeEstoque(ProdutoServico produtoServico)
        {
            InitializeComponent();
            _produtoServico = produtoServico;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                Nome = txtNome.Text,
                Quantidade = int.Parse(txtQuantidade.Text),
                Preco = decimal.Parse(txtPreco.Text)
            };

            _produtoServico.CadastrarProduto(produto);
            MessageBox.Show("Produto cadastrado com sucesso!");
            CarregarProdutos();
        }

        private void FrmControleDeEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            var produtos = _produtoServico.ObterTodosProdutos();
            dtgView.DataSource = produtos;
        }

        private void dtgView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                var selectedRow = dtgView.SelectedRows[0];
                var produtoSelecionado = (Produto)selectedRow.DataBoundItem;

                txtNome.Text = produtoSelecionado.Nome;
                txtQuantidade.Text = produtoSelecionado.Quantidade.ToString();
                txtPreco.Text = produtoSelecionado.Preco.ToString();

                _produtoIdSelecionado = produtoSelecionado.Id;
                Console.WriteLine($"ID do produto selecionado: {_produtoIdSelecionado}");
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtPreco.Text = string.Empty;
            _produtoIdSelecionado = 0;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_produtoIdSelecionado > 0)
            {
                try
                {
                    _produtoServico.ExcluirProduto(_produtoIdSelecionado);
                    MessageBox.Show("Produto excluído com sucesso!");
                    LimparCampos();
                    CarregarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o produto: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado.");
            }
        }
    }
}