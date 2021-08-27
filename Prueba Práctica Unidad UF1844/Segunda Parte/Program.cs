using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_Parte
{
    class Program
    {
        static void Main(string[] args)
        {
            RepartidorGlovo Federico = new RepartidorGlovo("Federico Gando", "GLOVO", 10, 2, 5);
            Federico.SueldoTrabajador();
            Console.ReadKey();
        }
    }
}
