using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoDeMañanaDia27
{
    class Moto:Vehiculo
    {
        protected bool _sidecar;

        public Moto() { }

        public Moto(int ID, string Marca, string Modelo, int KM, double Precio, bool Sidecar) : base(ID, Marca, Modelo, KM, Precio)
        {
            this._sidecar = Sidecar;
        }

        public bool PSidecar 
        {
            get { return _sidecar; }
            set { _sidecar = value; }
        }

        public void ListarMoto()
        {
            string sidecar = "No";
            if (_sidecar == true) { sidecar = "Si"; _Precio = _Precio + 50; }
            Console.WriteLine("El id del Coche es: " + _ID + "\nMarca: " + _Marca + "\nModelo: " + _Modelo + "\nKM recorridos: " + _KM + "\nPrecio: " + _Precio + " Euros\nSidecar:" + sidecar);
        }
    }
}
