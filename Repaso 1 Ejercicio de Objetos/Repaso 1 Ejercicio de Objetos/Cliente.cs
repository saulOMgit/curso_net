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
        private string _Codigo;

        public Cliente()
        {

        }

        public Cliente(string nombres,string apellidos, string documento, string categoria, string codigo):base(nombres,apellidos,documento)
        { 
            this._Categoria = categoria;
            this._Codigo = codigo;
        }

        public string Pcategoria 
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }
        public string Pcodigo 
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        public void generarCodigo() 
        {
            this.Pcodigo="C" + Pnombres.Substring(0, 3) + Pdocumento.Substring(0, 2);
        }
    }
}
