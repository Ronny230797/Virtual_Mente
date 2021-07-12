using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Virtual_Mente.Models;

namespace Virtual_Mente.Controllers
{
    public class QuestionGameStoryController : Controller
    {
        int idPregunta;
        string opcion1 = "";
        string opcion2 = "";
        string opcion3 = "";
        string opcion4 = "";

        // GET: QuestionGameStory
        public ActionResult QuestionGameStory(string Department = "")
        {
            ViewBag.Dep = Department;
            ViewBag.Pregunta = traerPreguntas(Department);
            ViewBag.IdPregunta = traerOpciones();
            ViewBag.Opcion1 = opcion1;
            ViewBag.Opcion2 = opcion2;
            ViewBag.Opcion3 = opcion3;
            ViewBag.Opcion4 = opcion4;
            return PartialView();
        }
        public ActionResult Main(string Department = "")
        {
            ViewBag.Department = Department;
            ViewBag.Pregunta = traerPreguntas(Department);
            ViewBag.IdPregunta = traerOpciones();
            ViewBag.Opcion1 = opcion1;
            ViewBag.Opcion2 = opcion2;
            ViewBag.Opcion3 = opcion3;
            ViewBag.Opcion4 = opcion4;
            return View();
        }
        public string traerPreguntas(string Department = "")
        {
            int idCate = 0;
            string txt = "";
            List<Pregunta> listaPreguntasCat = new List<Pregunta>();
            VirtualMenteEntities db = new VirtualMenteEntities();

            var exist = db.CATEGORIA.FirstOrDefault(x => x.DescCategoria == Department);


            if (exist == null)
            {
                txt = traerPreguntasCuento(Department);
            }
            else
            {
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
                txt = listaPreguntasCat[aleatorio].descripcion;
                idPregunta = listaPreguntasCat[aleatorio].id;


            }

            return txt;
        }

        public int traerOpciones()
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

            return idPregunta;

        }


        public string traerPreguntasCuento(string titulo = "")
        {
            List<Pregunta> listaPreguntasCat = new List<Pregunta>();
            VirtualMenteEntities db = new VirtualMenteEntities();
            var exist = db.TIPO_JUEGO.FirstOrDefault(x => x.Titulo == titulo);
            List<Pregunta> list = db.PREGUNTA.Select(x => new Pregunta
            {
                id = x.IDpregunta,
                descripcion = x.DescPregunta,
                idTipoJuego = x.IDTipoJuegoFK,
                idCategoria = x.IDCategoriaFK
            }).ToList();

            foreach (Pregunta var in list)
            {
                if (exist.IDTipoJuego == var.idTipoJuego)
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
        public JsonResult isCorrectCuento(int id, string respuesta)
        {

            VirtualMenteEntities db = new VirtualMenteEntities();
            string response = "Ok";
                        
            var respuestaCorrecta = db.OPCION
                .Where(z => z.IDPeguntaFK == id)
                .Select(xy => xy.REPUESTA_CORRECTA.DescRepuesta)
                .FirstOrDefault();

            if (respuestaCorrecta.Equals(respuesta))
            {
                response = "Ok";
            }
            else
            {
                response = respuestaCorrecta;
            }

            return Json(response, JsonRequestBehavior.AllowGet);

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
            public int RespuestaCorrecta { set; get; }
        }
        public class TipoJuego
        {
            public int idTipoJuego { set; get; }
            public string descTipoJuego { set; get; }
            public string Titulo { set; get; }
        }
    }
}