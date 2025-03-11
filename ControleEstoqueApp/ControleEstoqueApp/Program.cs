using ControleEstoqueApp.Infraestrutura.Database;
using ControleEstoqueApp.Repositorio;
using ControleEstoqueApp.Servicos;
using System;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var context = new AppDbContext();
            var produtoRepositorio = new ProdutoRepositorio(context);
            var produtoServico = new ProdutoServico(produtoRepositorio);

            Application.Run(new FrmControleDeEstoque(produtoServico));
        }
    }
}