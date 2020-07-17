using trabalhoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoas.Controllers
{ 
    public class CampanhasController : Controller
    {
        CampanhasBD bd = new CampanhasBD();
    
       
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(bd.lista());
        }
        [AllowAnonymous]
        public ActionResult criar()
        {
            return View();
        }
        public ActionResult Pesquisar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Pesquisar(string Nome)
        {
            ViewBag.ListaComercio = bd.pesquisa(Nome);
            return View();
        }

    }
}