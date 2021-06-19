using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Virtual_Mente.Controllers
{
    public class RandomCategoryController : Controller
    {
        // GET: RandomCategory

        public ActionResult test()
        {
            ViewBag.Materia = randomCategory();
            return View();
        }

        private String randomCategory()
        {
            Random r1 = new Random();
            string asignature = "";
            string[] array = new string[5] {"Español","Matemáticas","Estudios Sociales","Ciencias Naturales","Inglés"};
            int aleatorio = r1.Next(array.Length);
            asignature = array[aleatorio];
            return asignature;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}