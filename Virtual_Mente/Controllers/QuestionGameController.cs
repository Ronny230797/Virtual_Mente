using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Virtual_Mente.Models;

namespace Virtual_Mente.Controllers
{
    public class QuestionGameController : Controller
    {
        

        public ActionResult Main(string Department = "")
        {
            ViewBag.Department = Department;
            ViewBag.Pregunta = traerPreguntas(Department);
            return View();
        }

        public ActionResult _StructureQuestion(string Depart)
        {
            ViewBag.Dep = Depart;
            ViewBag.Pregunta = traerPreguntas(Depart);
            return PartialView();
        }
        // DIVIDIR ESTE METODO
        public string traerPreguntas(string Department = "")
        {
            int idCate = 0;
            List<Pregunta> listaPreguntasCat = new List<Pregunta>();
            VirtualMenteEntities db = new VirtualMenteEntities();

            var exist = db.CATEGORIA.FirstOrDefault(x => x.DescCategoria == Department);

            idCate = exist.IDcategoria;

            List<Pregunta> list = db.PREGUNTA.Select(x => new Pregunta
            {
                id = x.IDpregunta,
                description = x.DescPregunta,
                idTipoJuego = x.IDTipoJuegoFK,
                idCategoria = x.IDCategoriaFK
            }).ToList();

            foreach (Pregunta var in list)
            {
                if (var.idCategoria == idCate)
                {
                    listaPreguntasCat.Add(var);
                }
            }

            Random r1 = new Random();

            int aleatorio = r1.Next(listaPreguntasCat.Count);
            string txt = listaPreguntasCat[aleatorio].description;

            return txt;
        }

        public class Pregunta
        {
            public int id { set; get; }
            public string description { set; get; }
            public int idTipoJuego { set; get; }
            public int idCategoria { set; get; }
        }

    }
}
