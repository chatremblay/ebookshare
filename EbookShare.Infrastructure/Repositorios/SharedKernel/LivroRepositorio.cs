using EbookShare.Domain.SharedKernel;

namespace EbookShare.Infrastructure.Repositorios.SharedKernel
{
    public class LivroRepositorio : ILivroRepositorio
    {
        public Livro ObterLivro(int id)
        {
            return new Livro() { Isbn = 1, Nome = "O senhor dos anéis" };
        }
    }
}
