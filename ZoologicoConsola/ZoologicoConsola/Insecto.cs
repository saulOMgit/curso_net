using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoConsola
{
    class Insecto:Animal
    {
        bool vuela;
        //Constructor por defecto
        public Insecto()
        { }
        public Insecto(string especie, string nombre, double peso, int jaula, bool vuela) : base(especie, nombre, peso, jaula)
        {
            this.vuela = vuela;
        }

        public bool Vuela
        {
            get { return vuela; }
            set { vuela = value; }
        }

        public override void QueClaseDeAnimalEres()
        {
            string volador;
            if (vuela == true) { volador = "Si"; } else { volador = "No"; }

            Console.WriteLine("Especie: " + Pespecie + "\nNombre: " + Pnombre + "\nPeso: " + Ppeso + "\nNº Jaula: " + Pjaula + "\nVuela:" + volador);
        }
    }
}
