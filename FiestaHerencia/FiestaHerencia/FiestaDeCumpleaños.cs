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
    }
}
