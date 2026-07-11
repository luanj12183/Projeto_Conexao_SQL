using Microsoft.AspNetCore.Mvc;
using Projeto_Conexao_MYSQL;
using System.Collections.Generic;

namespace Projeto_Conexao_MYSQL.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {

            List <int> ids = new List<int> { 1, 2, 3};
            List<int> estoques = new List<int> {30, 50, 60};

            List<string> nomes = new List<string>
            {
                "Teclado",
                "Notebook",
                "Cabo de Rede"
            };

            List<double> precos = new List<double>
            {
                400.00,
                3500.00,
                70.50
            };

         ViewBag.ID = ids;
         ViewBag.Estoques = estoques;

         ViewBag.NomesProdutos = nomes;
         ViewBag.Precos = precos;

            return View();
        }
    }
}