using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Repaso_de_Clases
{
    class Producto
    {
        //campos privados
        private string _nombre;
        private int _precio;
        private string _categoria;
        
        //constructor por defecto
        public Producto() 
        {        
        }
        //constructor con parámetros
        public Producto(string nombre, int precio, string categoria) 
        {
            this._nombre = nombre;
            this._precio = precio;
            this._categoria = categoria;
        }
        public Producto(string nombre, int precio) 
        {
            this._nombre = nombre;
            this._precio = precio;
        }

        //get y set
        public string Pnombre 
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Pprecio 
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public string Pcategoria 
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        //Variable para mostrar los datos, funciona sin categoria
        public void Mostrar() 
        {
            Console.WriteLine("Nombre: " + _nombre + "\nPrecio: " + _precio + "\nCategoria: " + _categoria);
        }

    }
}
