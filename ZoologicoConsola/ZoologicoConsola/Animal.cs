using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoConsola
{
   abstract class Animal
    {
        //Todos sus campos privados
        protected string _especie;
        protected string _nombre;
        protected double _peso;
        protected int _jaula;

        //constructor por defecto 
        public Animal()
        {
        }
        //constructor con parámetros
        public Animal(string especie, string nombre,double peso, int jaula)
        {
            this._especie = especie;
            this._nombre = nombre;
            this._peso = peso;
            this._jaula = jaula;
        }

        //get y set
        public string Pespecie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        public string Pnombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public double Ppeso
        {
            get { return _peso; }
            set { _peso = value; }
        }


        public int Pjaula
        {
            get { return _jaula; }
            set { _jaula = value; }
        }
    
        public virtual void QueClaseDeAnimalEres()
        {
        }
    }
}
