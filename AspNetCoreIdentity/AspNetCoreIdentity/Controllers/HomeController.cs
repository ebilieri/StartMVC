using AspNetCoreIdentity.Extensions;
using AspNetCoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreIdentity.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            throw new System.Exception("Erro");
            return View();
        }

        [Authorize(Roles = "Admin, Gestor")]
        public IActionResult Secret()
        {
            return View();
        }

        [Authorize(Policy = "Excluir")]
        public IActionResult SecretClaim()
        {
            return View("Secret");
        }

        [Authorize(Policy = "Escrever")]
        public IActionResult SecretClaimGravar()
        {
            return View("Secret");
        }

        [ClaimsAuthorize("Produtos", "Lere")]
        public IActionResult SecretClaimCustom()
        {
            return View("Secret");
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            if (id == 500)
            {
                modelErro.Mensagem = "Ocorreu um erro! Tente novamente mais tarde.";
                modelErro.Titulo = "Ocorreu um erro!";
                modelErro.ErroCode = id;
            }
            else if (id == 404)
            {
                modelErro.Mensagem = "A página que você esta procurando não existe!";
                modelErro.Titulo = "Página não encontrada!";
                modelErro.ErroCode = id;
            }
            else if (id == 403)
            {
                modelErro.Mensagem = "Você não tem permissão para acessar esse recurso.";
                modelErro.Titulo = "Acesso negado!";
                modelErro.ErroCode = id;
            }
            else
            {
                return StatusCode(404);
            }

            return View("Error", modelErro);
        }
    }
}
