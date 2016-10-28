using FIap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIap.Exemplo01.MVC.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(produtos);
        }

        [HttpGet] //carrega a página com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        //mvcaction4
        [HttpPost]
        public ActionResult Cadastrar(Produto p)
        {
            TempData["msg"] = "Produto Cadastrado!";
            produtos.Add(p);
            //omito segundo parametro(controller), ele entende que é para o mesmo controller
            //no caso vai ser GET, não tem parametros
            return RedirectToAction("Cadastrar"); 
        }
    }
}