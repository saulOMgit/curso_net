using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoDeMañanaDia27
{
    class Coche:Vehiculo
    {
        protected bool _Airbag;

        public Coche() 
        {        
        }

        public Coche(int ID, string Marca, string Modelo, int KM, double Precio, bool Airbag) : base(ID, Marca, Modelo, KM, Precio) 
        {
            this._Airbag = Airbag;
        }

        public bool PAirbag 
        { 
            get { return _Airbag; }
            set { _Airbag = value; }
        }
        
        public void ListarCoche() 
        {
            string airbag="No";
            if (_Airbag == true) { airbag = "Si";}
            Console.WriteLine("El id del Coche es: "+_ID+"\nMarca: "+_Marca+"\nModelo: "+_Modelo+"\nKM recorridos: "+_KM+"\nPrecio: "+_Precio+" Euros\nAirbag:"+airbag);
        }

        public void PrecioAirbag() 
        {
            if (_Airbag == true) { _Precio = _Precio + 200; }
            else { }
        }
        
        
    }
}
