using EbookShare.Domain.SharedKernel;

namespace EbookShare.Infrastructure.Repositorios.SharedKernel
{
    public class LivroRepositorio : ILivroRepositorio
    {
        public Livro ObterLivro(int id)
        {
            return new Livro();
        }
    }
}
