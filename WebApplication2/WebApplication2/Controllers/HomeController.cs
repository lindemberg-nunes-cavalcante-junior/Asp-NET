using Serviço.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
         private CategoriaServico produtoServico = new CategoriaServico();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Destaque = new SelectList(produtoServico.ObterDestaques());
            ViewBag.UltimosAD = new SelectList(produtoServico.ObterUltimosProdutos());
            return View();
        }
    }
}