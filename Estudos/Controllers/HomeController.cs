using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estudos.Controllers
{
    public class HomeController : Controller
    {

        private Aplicacao.UserAplicacao applanche;
       


        public HomeController()
        {
            applanche = AlimentosAplicacaoConstrutor.AlimentosAplicacaoEF();
           
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}