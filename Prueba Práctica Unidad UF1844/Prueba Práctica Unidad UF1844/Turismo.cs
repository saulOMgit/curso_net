using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Práctica_Unidad_UF1844
{
    class Turismo:Vehiculo
    {
        //propiedad exclusiva de esta subclase
        protected bool clasico;
        //constructor por defecto
        public Turismo() { }
        //constructor por parametros
        public Turismo(double PrecioVenta, double CostoFabrica, string NombreVehiculo, bool Clasico):base(PrecioVenta,CostoFabrica,NombreVehiculo)
        {
            this.clasico = Clasico;
        }
        
        //getters y setters
        public bool PClasico
        {
            get { return clasico; }
            set { clasico = value; }
        }

        //Método para imprimir propiedades
        public void ListarTurismo() 
        {
            Console.WriteLine("Tipo: Turismo, Precio: " + precioVenta +", Nombre: " + nombreVehiculo + ",Clasico: " + clasico); ;
        }

    }
}
