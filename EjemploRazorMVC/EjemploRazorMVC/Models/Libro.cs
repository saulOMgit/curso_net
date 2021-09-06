using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploRazorMVC.Models
{
    public class Libro
    {
        public string Isbn;
        public string Titulo;
        public string TipoLibro;

        public Libro() { }

        public Libro(string isbn, string titulo, string tipolibro)
        {
            this.Isbn = isbn;
            this.Titulo = titulo;
            this.TipoLibro = tipolibro;
        }

        public string PIsbn 
        {
            get { return Isbn; }
            set { Isbn = value; }
        }
        public string Ptitulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }
        public string Ptipolibro
        {
            get { return TipoLibro; }
            set { TipoLibro = value; }
        }

        
    }
}