using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EbookShare.Domain.SharedKernel;
using EbookShare.Infrastructure.Repositorios.SharedKernel;

namespace EbookShare.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Livros")]
    public class LivrosController : Controller
    {
        [HttpGet("")]
        public IActionResult ObterLivros()
        {
            var repositorio = new LivroRepositorio();

            var livros = new List<Livro>() { repositorio.ObterLivro(2) };
            
            if (!livros.Any())
                return NotFound();

            return Ok(livros);
        }
    }
}