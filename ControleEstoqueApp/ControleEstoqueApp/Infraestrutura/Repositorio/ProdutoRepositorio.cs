using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.Database;
using System.Collections.Generic;
using System.Linq;

namespace ControleEstoqueApp.Repositorio
{
    public class ProdutoRepositorio
    {
        private readonly AppDbContext _context;

        public ProdutoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Remover(int produtoId)
        {
            var produto = _context.Produtos.Find(produtoId);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }
        }

        public List<Produto> ObterTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}