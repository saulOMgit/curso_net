using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjemploRazorMVC;
using EjemploRazorMVC.Models;

namespace EjemploRazorMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            //ViewBag.Mensaje = "Hola Mundo";
            //return View();

            //var libro = new Libro { Isbn = "1122", Titulo = "El principito", TipoLibro = "Novela" };
            //return View(libro);
            var libros = new List<Libro>
            {
                new Libro {Isbn = "1122", Titulo = "El principito", TipoLibro = "Novela"}, new Libro {Isbn = "1122",
                Titulo = "Steve Jobs", TipoLibro =  "Biografía"}
            };

            return View(libros);
        }
    }
}