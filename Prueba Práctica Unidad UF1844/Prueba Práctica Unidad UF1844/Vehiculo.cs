using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Práctica_Unidad_UF1844
{
    class Vehiculo
    {
        //propiedades
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreVehiculo;

        //constructor por defecto
        public Vehiculo() { }

        //constructor por parametros
        public Vehiculo(double PrecioVenta, double CostoFabrica, string NombreVehiculo) 
        {
            this.precioVenta = PrecioVenta;
            this.costoFabrica = CostoFabrica;
            this.nombreVehiculo = NombreVehiculo;
        }

        //getters y setters

        public double PPrecioVenta 
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public double PCostroFabrica 
        {
            get { return costoFabrica; }
            set { costoFabrica = value; }
        }
        public string PNombreVehiculo 
        {
            get { return nombreVehiculo; }
            set { nombreVehiculo = value; }
        }

    }
}
