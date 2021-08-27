using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_Parte
{
    class Persona
    {
        //propiedades
        protected string nombre;
        protected string empresa;

        //constructor por defecto

        public Persona() 
        {
        }

        //constructor por parametros
        public Persona(string Nombre,string Empresa) 
        {
            this.nombre = Nombre;
            this.empresa = Empresa;
        }

        //getters y setters
        public string Pnombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Pempresa 
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public void listar() 
        {
            Console.WriteLine("Nombre: "+nombre+"\nEmpresa:");
        }


    }
}
