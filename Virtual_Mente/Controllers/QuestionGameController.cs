using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Virtual_Mente.Controllers
{
    public class QuestionGameController : Controller
    {

        public ActionResult Main()
        {
            return View();
        }

        public ActionResult _StructureQuestion()
        {
            return PartialView();
        }

    }
}
