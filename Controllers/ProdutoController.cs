using Fiap.Web.Donation1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Donation1.Controllers
{
    public class ProdutoController : Controller
    {
        private List<ProdutoModel> produtos;

        public ProdutoController()
        {
            // Acesso fake ao banco dados

            produtos = new List<ProdutoModel>{
                new ProdutoModel()
                {
                    ProdutoId = 1,
                    Nome = "Iphone 11",
                    TipoProdutoId = 1,
                    Disponivel = true,
                    DataExpiracao = DateTime.Now,
                },
                new ProdutoModel()
                {
                    ProdutoId = 2,
                    Nome = "Iphone 12",
                    TipoProdutoId = 2,
                    Disponivel = true,
                    DataExpiracao = DateTime.Now,
                },
                new ProdutoModel()
                {
                    ProdutoId = 3,
                    Nome = "Iphone 13",
                    TipoProdutoId = 1,
                    Disponivel = true,
                    DataExpiracao = DateTime.Now,
                },

                 new ProdutoModel()
                {
                    ProdutoId = 4,
                    Nome = "Iphone 14",
                    TipoProdutoId = 1,
                    Disponivel = false,
                    DataExpiracao = DateTime.Now,
                },
            };
        }

       [HttpGet]
        public IActionResult Index() //Lista todos os produtos
        {
            //Consultar o banco de dados;

            //TempData["Produtos"] = produtos;
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View(new ProdutoModel());
        }

        [HttpPost]
        public IActionResult Novo(ProdutoModel produtoModel)
        {
            //Gravando no banco de dados

            //INSERT INTO PRODUTO VALUES

            // ViewBag.Produtos = produtos;

            if (string.IsNullOrEmpty(produtoModel.Nome))
            {
                ViewBag.Mensagem = "O campo nome é requerido";
                return View(produtoModel);
            }
            else
            {
                //UPDATE

                // ViewBag.Produtos = produtos;

                TempData["Mensagem"] = $"{produtoModel.Nome} cadastrado com sucesso";
                //ViewBag.Mensagem = $"{produtoModel.Nome} cadastrado com sucesso";

                return RedirectToAction("Index");

            }
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            //SELECT * FROM produto where ProdutoId = {id}

            var produto = produtos[id - 1];

            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(ProdutoModel produtoModel)
        {
            if (string.IsNullOrEmpty(produtoModel.Nome))
            {
                ViewBag.Mensagem = "O campo nome é requerido";
                return View(produtoModel);
            }
            else
            {
                //UPDATE

                // ViewBag.Produtos = produtos;

                TempData["Mensagem"] = $"{produtoModel.Nome} alterado com sucesso";
                //ViewBag.Mensagem = $"{produtoModel.Nome} cadastrado com sucesso";

                return RedirectToAction("Index");

            }
        }
    }
}
