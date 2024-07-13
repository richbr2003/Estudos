using Estudos.Models;
using PagedList;
using Rotativa.Core.Options;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa.MVC;

namespace Estudos.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly Contexto contexto;

        public RelatoriosController()
        {
            contexto = new Contexto();
        }

        // GET: Relatorios
        public ActionResult Index(int? pagina, Boolean? gerarPDF)
        {


            //var view = new Microsoft.Reporting.WebForms.ReportViewer();

            //teste
            //view.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;

            var listagemClientes =contexto.pessoa.OrderBy(n => n.id).ToList<Pessoa>();
            gerarPDF = false;
            pagina = 1;
            if (gerarPDF != true)
            {
                //Definindo a paginação
                int paginaQdteRegistros = 10;
                int paginaNumeroNavegacao = (pagina ?? 1);

                return View(listagemClientes.ToPagedList(paginaNumeroNavegacao,
                paginaQdteRegistros));
            }
            else
            {
                int paginaNumero = 1;

                var pdf = new ViewAsPdf
                {
                    ViewName = "Index",
                    //PageSize = Size.A4,
                    //IsGrayScale = true,
                    Model = listagemClientes.ToPagedList(paginaNumero, listagemClientes.Count)
                };
                return pdf;
            }
           
        }
    }
}