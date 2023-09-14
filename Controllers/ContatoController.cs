using Fiap.Web.Donation1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Fiap.Web.Donation1.Controllers
{
    public class ContatoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Gravar(ContatoModel contatoModel)
        {
            string mensagem = string.Empty;
            if (contatoModel.Email.Equals("fmoreni@gmail.com"))
            {
                mensagem = $"Contato do usuário {contatoModel.Nome} não registrado, pois o mesmo já existe ";
            }
            else
            {
                mensagem = "Contato registrado com sucesso";
            }

            ViewBag.Mensagem = mensagem;
            
            return View("Sucesso");
        }

        [HttpGet]
        public IActionResult Help()
        {
            return View();
        }
    }
}
