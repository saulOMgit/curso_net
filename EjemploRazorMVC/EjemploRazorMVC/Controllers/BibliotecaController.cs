using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjemploRazorMVC.Models;

namespace EjemploRazorMVC.Controllers
{
    public class BibliotecaController : Controller
    {
        static Biblioteca miBiblioteca = new Biblioteca();
        // GET: Biblioteca
        public ActionResult Index()
        {
            return View(miBiblioteca.Libros.ToList());
        }

        // GET: Biblioteca/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Biblioteca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Biblioteca/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                miBiblioteca.Libros.Add(new Libro
                {
                    Isbn=(miBiblioteca.Libros.Count()+1).ToString(),
                    Titulo = collection["Titulo"],
                    TipoLibro = collection["Categoria"]
                    });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Biblioteca/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Biblioteca/Edit/5
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

        // GET: Biblioteca/Delete/5
        public ActionResult Delete(string id)
        {
            return View(miBiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // POST: Biblioteca/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                foreach(Libro l in miBiblioteca.Libros)
                {
                    if (l.Isbn == id) miBiblioteca.Libros.Remove(l);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
