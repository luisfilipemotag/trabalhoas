using trabalhoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoas.Controllers
{ 
    public class FuncionarioController : Controller
    {
        FuncionarioBD bd = new FuncionarioBD();
    
        // GET: FUNCIONARIOS
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

       
       
    }
}