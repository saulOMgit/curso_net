using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_1_Ejercicio_de_Objetos
{
    public class Persona
    {
        //Todos sus campos privados
        private string _Nombres;
        private string _Apellidos;
        private string _Documento;

        //Constructor por defecto
        public Persona() 
        {
            _Nombres = "";
            _Apellidos = "";
            _Documento = "";
        }

        //Constructor con parametros
        public Persona(string nombres, string apellidos, string documento) 
        {
            this._Nombres = nombres;
            this._Apellidos = apellidos;
            this._Documento = documento;
        }

        //get y set
        public string Pnombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public string Papellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        public string Pdocumento 
        {
            get { return _Documento;}
            set { _Documento = value; }
        }
    }
}
