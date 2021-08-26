using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoDeMañanaDia27
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche lere = new Coche(001, "BMW", "X4", 10000, 500000, true);
            lere.ListarCoche();
            Console.ReadKey();
        }
    }
}
