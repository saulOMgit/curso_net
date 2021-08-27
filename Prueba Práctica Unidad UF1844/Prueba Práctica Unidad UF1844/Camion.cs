using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Práctica_Unidad_UF1844
{
    class Camion : Vehiculo
    {
        //propiedad exclusiva de esta clase
        protected double toneladas;

        //constructor por defecto
        public Camion() { }

        //constructor por parametros
        public Camion(double PrecioVenta, double CostoFabrica, string NombreVehiculo, double Toneladas) : base(PrecioVenta, CostoFabrica, NombreVehiculo)
        {
            this.toneladas = Toneladas;
        }

        //getters y setters
        public double PToneladas 
        {
            get { return toneladas; }
            set { toneladas = value; }
        }

        //listar los datos  de la clase Camión
        public void ListarCamion()
        {
            Console.WriteLine("Tipo: Camión, Precio: " + PPrecioVenta + ",Precio: " + PPrecioVenta + ", Nombre: " + PPrecioVenta + ",Toneladas: " + PToneladas); ; ;
        }
    }
}
