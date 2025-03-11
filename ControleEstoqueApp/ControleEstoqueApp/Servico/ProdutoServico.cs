using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Repositorio;
using System.Collections.Generic;

namespace ControleEstoqueApp.Servicos
{
    public class ProdutoServico
    {
        private readonly ProdutoRepositorio _repositorio;

        public ProdutoServico(ProdutoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void CadastrarProduto(Produto produto)
        {
            _repositorio.Adicionar(produto);
        }

        public void ExcluirProduto(int produtoId)
        {
            _repositorio.Remover(produtoId);
        }

        public List<Produto> ObterTodosProdutos()
        {
            return _repositorio.ObterTodos();
        }
    }
}