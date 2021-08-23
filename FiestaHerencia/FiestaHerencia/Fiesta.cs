using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiestaHerencia
{
    class Fiesta
    {
        private int _NumeroDePersonas;
        private double _CostoDeDecoracion;
        private double _bonoExtra;
        private double _CostodeComidaPorPersona;
        private bool _Decora;

        //Constructor por defecto
        public Fiesta() 
        {
            _NumeroDePersonas = 0;
            _CostoDeDecoracion = 0;
            _bonoExtra = 0;
            _CostodeComidaPorPersona = 0;
            _Decora = false;
        }

        //Constructor por parametros
        public Fiesta(int NumeroDePersonas,double CostoDeDecoracion,double bonoExtra, double CostodeComidaPorPersona, bool Decora) 
        {
            this._NumeroDePersonas = NumeroDePersonas;
            this._CostoDeDecoracion = CostoDeDecoracion;
            this._bonoExtra = bonoExtra;
            this._CostodeComidaPorPersona = CostodeComidaPorPersona;
           this. _Decora = Decora;
        }

        //getters y setters

        public int PNumeroDePersonas 
        { get { return _NumeroDePersonas; } set { _NumeroDePersonas = value; } }

        public double PCostoDeDecoracion
        { get { return _CostoDeDecoracion; } set { _CostoDeDecoracion = value; } }

        public double PbonoExtra
        { get { return _bonoExtra; } set { _bonoExtra = value; } }

        public double PCostodeComidaPorPersona
        { get { return _CostodeComidaPorPersona; } set { _CostodeComidaPorPersona = value; } }

        public bool PDecora
        { get { return _Decora; } set { _Decora = value; } }

        public void CalcularCostoDeDecoracion()
        {        
        }

        public void CalcularCosto() 
        { 
  
        }


    }
}
