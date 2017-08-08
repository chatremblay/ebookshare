using System;
using System.Collections.Generic;
using System.Text;

namespace EbookShare.Domain.SharedKernel
{
    public interface ILivroRepositorio
    {
        Livro ObterLivro(int id);
    }
}
