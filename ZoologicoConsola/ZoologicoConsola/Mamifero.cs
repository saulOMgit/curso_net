using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoConsola
{
    class Mamifero:Animal
    {
        //Constructor por defecto
        public Mamifero() 
        { }
        public Mamifero(string especie, string nombre, double peso, int jaula):base(especie, nombre, peso, jaula)
        { }
        public override void QueClaseDeAnimalEres()
        {
        Console.WriteLine("Especie: " + Pespecie + "\nNombre: " + Pnombre + "\nPeso: " + Ppeso + "\n Nº Jaula: " + Pjaula);
    }
}
}
