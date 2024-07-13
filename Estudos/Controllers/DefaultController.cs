using Estudos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estudos.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Contexto contexto;

        public DefaultController()
        {
            contexto = new Contexto();
        }


        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //// GET: Default/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Default/Create
        [HttpPost]
        public ActionResult Index(Pessoa entidade)
        {
            if (ModelState.IsValid)
            {

                try
                {


                   
                    contexto.pessoa.Add(entidade);
                    contexto.SaveChanges();
                   
                   

                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
