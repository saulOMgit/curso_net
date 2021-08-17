using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_1_Ejercicio_de_Objetos
{
    class Cliente : Persona
    {
        private string _Categoria;
        private double _Codigo;

        public Cliente()
        {

        }

        public Cliente(string nombres,string apellidos, string documento, string categoria, double codigo):base(nombres,apellidos,documento)
        { 
            this._Categoria = categoria;
            this._Codigo = codigo;
        }

        public string Pcategoria 
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }
        public void generarCodigo() 
        {
            Console.WriteLine("C"+Pnombres.Substring(0,3)+Pdocumento.Substring(0,2));
        }
    }
}
