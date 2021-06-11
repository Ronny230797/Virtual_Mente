using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Virtual_Mente.Models;

namespace Virtual_Mente.Controllers
{
    public class ChooseGameController : Controller
    {
        public ActionResult Main()
        {

            VirtualMenteEntities db = new VirtualMenteEntities();

            var list = db.CATEGORIA.FirstOrDefault();
            ViewBag.name = list.DescCategoria;
            return View();
        }
    }
}