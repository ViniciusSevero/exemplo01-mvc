using FIap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIap.Exemplo01.MVC.Web.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> _lista = new List<Cliente>();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(); // retorna a view CLiente/Cadastrar.cshtml
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente c)
        {
            TempData["msg"] = "Cadastrado com Sucesso"; //TempData para sobreviver à outra requisição
            _lista.Add(c);
            return RedirectToAction("Cadastrar"); //limpar campos (nova Request)
        }


        [HttpGet]
        public ActionResult Listar()
        {
            ViewBag.lista = _lista;
            //return View(_lista);
            return View();
        }

        [HttpGet]
        public ActionResult Editar(string nome)
        {
            Cliente cliente = null;
            foreach (var c in _lista)
            {
                if (nome.Equals(c.Nome))
                {
                    cliente = c;
                }
            }
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Cliente c)
        {
            for(int i = 0; i < _lista.Count; i++)
            {
                if (_lista[i].Nome.Equals(c.Nome))
                {
                    _lista[i] = c;
                }
            }
            return RedirectToAction("Listar", "Cliente");
        }

        [HttpPost]
        public ActionResult Excluir(string nome)
        {
            _lista.RemoveAll(c => c.Nome.Equals(nome));
            return RedirectToAction("Listar","Cliente");
        }
    }
}