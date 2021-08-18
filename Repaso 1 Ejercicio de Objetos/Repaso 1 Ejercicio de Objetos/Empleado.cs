using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_1_Ejercicio_de_Objetos
{
    class Empleado : Persona
    {
        private string _tipoContrato;
        private double _sueldo;

        public Empleado()
        {
        }

        public Empleado(string nombres, string apellidos, string documento, string tipopcontrato, double sueldo) : base(nombres, apellidos, documento) 
        {
            this._tipoContrato = tipopcontrato;
            this._sueldo = sueldo;
        }

        public string Ptipocontrato
        {
            get { return _tipoContrato; }
            set { _tipoContrato = value; }
        }
        public double Psueldo 
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }

        public void calcularSueldo() 
        {
            if (this.Ptipocontrato == "F" || this.Ptipocontrato == "f")
            {
                this.Psueldo = Psueldo + 300;

            }
           else if (this.Ptipocontrato=="T" || this.Ptipocontrato=="t")
            {
                this.Psueldo = Psueldo + 250;
            }
        }
    }
}
