using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Virtual_Mente.Controllers
{
    public class ShowTextImageController : Controller
    {
        String text;
        int index;

        public ActionResult Test()
        {
            ViewBag.Name = getText ();
            return View();
        }

        // GET: ShowTextImage
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShowTextImage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShowTextImage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShowTextImage/Create
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

        // GET: ShowTextImage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShowTextImage/Edit/5
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

        // GET: ShowTextImage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShowTextImage/Delete/5
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

        public String getText()
        {
            Random random = new Random();
            index = random.Next(0, 3);

            if (index == 0)
            {
                text = "Se presenta el cuenta de Tinkerbell.";
            }
            if (index == 1)
            {
                text = "Se presenta el cuenta de Balto.";
            }
            if (index == 2)
            {
                text = "Se presenta el cuenta de Tres Cerditos.";
            }
            return text;
        }

    }
}
