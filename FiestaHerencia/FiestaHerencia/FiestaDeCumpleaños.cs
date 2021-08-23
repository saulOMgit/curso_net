using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiestaHerencia
{
    class FiestaDeCumpleaños:Fiesta
    {
        private int _TamañoPastel;
        private string _TextoPastel;

        public FiestaDeCumpleaños() 
        {        
        }

        public FiestaDeCumpleaños(int NumeroDePersonas, double CostoDeDecoracion, double bonoExtra, double CostodeComidaPorPersona, bool Decora, int TamañoPastel, string TextoPastel):base(NumeroDePersonas, CostoDeDecoracion, bonoExtra, CostodeComidaPorPersona, Decora) 
        {
            this._TamañoPastel = TamañoPastel;
            this._TextoPastel = TextoPastel;
        }

        public int PTamañoPastel
        { get { return _TamañoPastel; } set { _TamañoPastel = value; } }

        public string PTextoPastel
        { get { return _TextoPastel; } set { _TextoPastel = value; } }

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
            if (PNumeroDePersonas > 4) 
            {
                _TamañoPastel = 100;
            }
            else { _TamañoPastel = 50; }
            double total = 0;
            if (PNumeroDePersonas > 20)
            {
                total = (PCostodeComidaPorPersona * PNumeroDePersonas) + PCostoDeDecoracion + PbonoExtra+_TamañoPastel;

            }
            else
            {
                total = (PCostodeComidaPorPersona * PNumeroDePersonas) + PCostoDeDecoracion+_TamañoPastel;
            }
            Console.WriteLine("Un total de " + total + " leuros");
        }
    }
}
