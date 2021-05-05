using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DecentralizationController : Controller
    {
        // GET: Decentralization
        public ActionResult Index()
        {
            return View();
        }

        // GET: Decentralization/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Decentralization/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Decentralization/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Decentralization/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Decentralization/Edit/5
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

        // GET: Decentralization/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Decentralization/Delete/5
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
