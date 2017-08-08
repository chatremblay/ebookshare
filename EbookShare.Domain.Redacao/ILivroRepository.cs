namespace EbookShare.Domain.Redacao.Entities
{
    public interface ILivroRepository
    {
        Livro ObterPorId(int id);
    }
}
