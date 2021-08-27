using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_Parte
{
    class RepartidorGlovo:Persona
    {

        protected double propinas;
        protected double desplazamientos;
        protected double preciodesplazamiento;

        //contructor por defecto
        public RepartidorGlovo() 
        { }

        //constructor por parametros
        public RepartidorGlovo(string Nombre, string Empresa,double Propinas, double Desplazamientos, double PrecioDesplazamiento):base(Nombre,Empresa) 
        {
            this.propinas = Propinas;
            this.desplazamientos = Desplazamientos;
            this.preciodesplazamiento = PrecioDesplazamiento;
        }

        //getters y setters
        public double PPropinas 
        { 
            get { return propinas; }
            set { propinas = value; }
        }
        public double Pdesplazamientos 
        {
            get { return desplazamientos; }
            set { desplazamientos = value; }
        }
        public double PPrecioDesplazamientos 
        {
            get { return preciodesplazamiento; }
            set { preciodesplazamiento = value; }
        }

        //metodo para listar el sueldo del trabajados
        public void SueldoTrabajador() 
        {
            double sueldo = desplazamientos * preciodesplazamiento + propinas;

            Console.WriteLine("El sueldo de " + nombre +"\nPor hacer "+desplazamientos+" desplazamientos por "+preciodesplazamiento+" euros por desplazamiento \ny "+propinas+" euros en propinas es de " + sueldo + " Euros. Pa eso que no salga de casa...");
        }
    }
}
