using EbookShare.CrossCutting.Domain;
using EbookShare.CrossCutting.Notifications;

namespace EbookShare.Domain.Redacao
{
    public class Autor : Notifiable, IEntityBase
    {
        public Autor(string nome)
        {
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
    }
}