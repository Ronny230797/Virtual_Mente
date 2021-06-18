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

            var exist = db.CATEGORIA.FirstOrDefault(x => x.DescCategoria == "Ciencias Naturales");

            if (exist == null) {

                CATEGORIA test = new CATEGORIA();
                test.DescCategoria = "Ciencias Naturales";

                db.CATEGORIA.Add(test);
                db.SaveChanges();
            }

            List<Object> list = db.CATEGORIA.Select(x=> new Object{ 
                 id = x.IDcategoria,
                 description = x.DescCategoria
            }).ToList();

            ViewBag.name = exist.DescCategoria;
            return View();
        }
    }


    public class Object {
        public int id { set; get; }
        public string description { set; get; }
    }

}