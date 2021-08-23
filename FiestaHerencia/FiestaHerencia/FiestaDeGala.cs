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

        double total = 0;

        public void CalcularCostoDeDecoracion()
        {
            if (PDecora == true)
            {
                if (PNumeroDePersonas > 20)
                {
                    PCostoDeDecoracion = PNumeroDePersonas * 200;
                }
                else { PCostoDeDecoracion = PNumeroDePersonas * 160; }
            }
            else { PCostoDeDecoracion = 0; }
        }

        public void CalcularCosto()
        {
            if (PNumeroDePersonas > 20)
            {
                total = (PCostodeComidaPorPersona * PNumeroDePersonas) + PCostoDeDecoracion + PbonoExtra + total;

            }
            else
            {
                total = (PCostodeComidaPorPersona * PNumeroDePersonas) + PCostoDeDecoracion + total;
            }
            Console.WriteLine("Un total de " + total + " leuros");
        }

        public void SetOpcionEXTRA() 
        {
            if (_OpcionExtra == true) 
            { total = PNumeroDePersonas * 40; }
        }
    }
}
