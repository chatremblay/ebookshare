using EbookShare.Domain.Redacao.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EbookShare.Domain.Redacao.Test
{
    [TestClass]
    public class LivroUnitTest
    {
        [TestMethod]
        [TestCategory("Livro Entity")]
        public void Deve_VersionsarAlteracoesNoLivro_ComSucesso()
        {
            var livroRepository = SetupLivroRepository();
            var livro = livroRepository.ObterPorId(1);

            livro.Atualizar("Nova versão");

            Assert.AreEqual(1, livro.Rascunhos.Count);
            Assert.AreEqual(1, livro.Rascunhos[0].Versao);
            Assert.AreEqual(string.Empty, livro.Rascunhos[0].Texto);
        }

        ILivroRepository SetupLivroRepository()
        {
            var autor = new Autor("Nome do Autor");
            var livro = new Livro("Viver em Paz", autor);

            var livroRepositoryMoq = new Mock<ILivroRepository>();
            livroRepositoryMoq.Setup(x => x.ObterPorId(It.IsAny<int>()))
                .Returns(livro);

            return livroRepositoryMoq.Object;
        }
    }
}
