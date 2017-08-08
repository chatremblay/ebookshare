using EbookShare.CrossCutting.Domain;

namespace EbookShare.Domain.Redacao
{
    public class Rascunho : IAggregateRoot
    {
        public int Id { get; private set; }

        public string Texto { get; private set; }
    }
}
