using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoConsola
{
    class Ave:Animal
    {
        string colorPlumaje;
        double alturaMaximaVuelo;
        //Constructor Base
        public Ave() 
        { }

        //Constructor Sobrecargado
        public Ave(string especie, string nombre, double peso, int jaula, string colorPlumaje, double alturaMaximaVuelo):base(especie, nombre, peso, jaula)
        {   this.colorPlumaje = colorPlumaje;
            this.alturaMaximaVuelo = alturaMaximaVuelo;
        }

        //Propiedad para los nuevos ¿campos?
        public string ColorPlumaje
        {
            get { return colorPlumaje; }
            set { colorPlumaje = value; }
        }

        public double AlturaMaximaVuelo 
        {
            get { return alturaMaximaVuelo; }
            set { alturaMaximaVuelo = value; }
        }

        public override void QueClaseDeAnimalEres()
        {
            Console.WriteLine("Especie: " + _especie + "\nNombre: " + _nombre + "\nPeso: " + _peso +"Kg"+ "\n Nº Jaula: " + _jaula+"\nColor Plumaje: "+colorPlumaje+"\nAltura Máxima de vuelo:"+alturaMaximaVuelo+" metros");
        }

    }
}
