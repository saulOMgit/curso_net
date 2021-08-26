using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoDeMañanaDia27
{
    class Vehiculo
    {
        protected int _ID;
        protected string _Marca;
        protected string _Modelo;
        protected int _KM;
        protected double _Precio;

        public Vehiculo() { }

        public Vehiculo(int ID,string Marca, string Modelo, int KM, double Precio)
        {
            this._ID = ID;
            this._Marca = Marca;
            this._Modelo = Modelo;
            this._KM = KM;
            this._Precio = Precio;
        }

        public int PID 
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string PMarca 
        {
            get { return _Marca; }
            set { _Marca = value; }
        }
        public string PModelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        public int PKM 
        {
            get { return _KM; }
            set { _KM = value; }
        }

        public double PPrecio 
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

    }
}
