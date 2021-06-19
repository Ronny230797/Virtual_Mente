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
        int idPregunta;
        string opcion1 = "";
        string opcion2 = "";
        string opcion3 = "";
        string opcion4 = "";

        public ActionResult Main(string Department = "")
        {
            ViewBag.Department = Department;
            ViewBag.Pregunta = traerPreguntas(Department);
            traerOpciones();
            ViewBag.Opcion1 = opcion1;
            ViewBag.Opcion2 = opcion2;
            ViewBag.Opcion3 = opcion3;
            ViewBag.Opcion4 = opcion4;
            return View();
        }

        public ActionResult _StructureQuestion(string Depart)
        {
            ViewBag.Dep = Depart;
            ViewBag.Pregunta = traerPreguntas(Depart);
            traerOpciones();
            ViewBag.Opcion1 = opcion1;
            ViewBag.Opcion2 = opcion2;
            ViewBag.Opcion3 = opcion3;
            ViewBag.Opcion4 = opcion4;
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
                descripcion = x.DescPregunta,
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
            string txt = listaPreguntasCat[aleatorio].descripcion;
            idPregunta = listaPreguntasCat[aleatorio].id;

            return txt;
        }

        public void traerOpciones()
        {
            VirtualMenteEntities db = new VirtualMenteEntities();
            List<Opcion> listaOpcionesXPregunta = new List<Opcion>();


            List<Opcion> listaOpciones = db.OPCION.Select(x => new Opcion
            {
                idOpcion = x.IDOpcion,
                descripcion = x.DescOpcion,
                idPreguntaFK = x.IDPeguntaFK,
                idRespuestaCorrectaFK = x.IDRepuestaCorrectaFK
            }).ToList();


            foreach (Opcion var in listaOpciones)
            {
                if (var.idPreguntaFK == idPregunta)
                {
                    listaOpcionesXPregunta.Add(var);
                }
            }

            opcion1 = listaOpcionesXPregunta[0].descripcion;
            opcion2 = listaOpcionesXPregunta[1].descripcion;
            opcion3 = listaOpcionesXPregunta[2].descripcion;
            opcion4 = listaOpcionesXPregunta[3].descripcion;

        }

        public class Pregunta
        {
            public int id { set; get; }
            public string descripcion { set; get; }
            public int idTipoJuego { set; get; }
            public int idCategoria { set; get; }
        }

        public class Opcion
        {
            public int idOpcion { set; get; }
            public string descripcion { set; get; }
            public int idPreguntaFK { set; get; }
            public int idRespuestaCorrectaFK { set; get; }
        }

    }
}
