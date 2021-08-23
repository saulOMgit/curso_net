using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiestaHerencia
{
    class FiestaDeGala:Fiesta
    {
        private double _CostoPromedioPorPersona;
        private bool _OpcionExtra;

        public FiestaDeGala() 
        { 
        }

        public FiestaDeGala(int NumeroDePersonas, double CostoDeDecoracion, double bonoExtra, double CostodeComidaPorPersona, bool Decora, double CostoPromedioPorPersona, bool OpcionExtra):base(NumeroDePersonas,CostoDeDecoracion,bonoExtra,CostodeComidaPorPersona,Decora)
        {
            this._CostoPromedioPorPersona = CostoPromedioPorPersona;
            this._OpcionExtra = OpcionExtra;
        }

        public double PCostoPromedioPorPersona
        { get { return _CostoPromedioPorPersona; } set { _CostoPromedioPorPersona = value; } }
        public bool POpcionExtra
        { get { return _OpcionExtra; } set { _OpcionExtra = value; } }
    }
}
