using EbookShare.CrossCutting.Domain;
using EbookShare.CrossCutting.Notifications;
using System.Collections.Generic;
using System.Linq;

namespace EbookShare.Domain.Redacao
{
    public class Livro : Notifiable, IAggregateRoot
    {
        public Livro(string titulo, Autor autor)
        {
            Titulo = titulo;
            Autor = autor;
            Rascunhos = new List<Rascunho>();
            Texto = string.Empty;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public Autor Autor { get; private set; }
        public string Texto { get; private set; }
        public IList<Rascunho> Rascunhos { get; private set; }

        public void Atualizar(string texto)
        {
            var rascunho = new Rascunho(this);

            AddNotifications(rascunho.Notifications);

            if (rascunho.IsValid())
                Rascunhos.Add(rascunho);
        }
    }
}
