using Microsoft.AspNetCore.Mvc;
using Projeto_Conexao_MYSQL.Models;
using System.Collections.Generic;

namespace Projeto_Conexao_MYSQL.Controllers
{
    
    public class ProdutoController : Controller
    {

        public IActionResult Index()
        {

            List<Produto> ListaProdutos = new List<Produto>()
            {

            new Produto { Id = 1, NomesProdutos = "Teclado", Estoques = 30, Precos = 400.00 },
            new Produto { Id = 2, NomesProdutos = "Notebook", Estoques = 50, Precos = 3500.00 },
            new Produto { Id = 3, NomesProdutos = "Cabo de Rede", Estoques = 60, Precos = 70.50 },
            };

            ViewBag.Produtos = ListaProdutos;

            return View();
        }
    }
}