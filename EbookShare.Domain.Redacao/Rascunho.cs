using EbookShare.CrossCutting.Domain;
using EbookShare.CrossCutting.Notifications;
using EbookShare.CrossCutting.Validators;
using System;

namespace EbookShare.Domain.Redacao
{
    public class Rascunho : Notifiable, IEntityBase
    {
        public Rascunho(Livro livro)
        {
            Livro = livro;
            Texto = livro.Texto;
            Versao = livro.Rascunhos.Count + 1;
            CriadoEm = DateTime.UtcNow;

        }

        public int Id { get; private set; }
        public Livro Livro { get; private set; }
        public int Versao { get; private set; }
        public string Texto { get; private set; }
        public DateTime CriadoEm { get; private set; }
    }
}
