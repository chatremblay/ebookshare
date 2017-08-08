using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EbookShare.Infrastructure.Repositorios.SharedKernel;

namespace EbookShare.Infrastucture.Testes
{
    [TestClass]
    public class LivroRepositorioTestes
    {
        [TestMethod]
        public void ObterLivroDeveRetornarLivro()
        {
            var repositorio = new LivroRepositorio();

            var livro = repositorio.ObterLivro(1);

            Assert.IsNotNull(livro);
        }
    }
}
