using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_1_Ejercicio_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente prueba = new Cliente("Willer","Iglesias","documento","Metalero",666);
            prueba.generarCodigo();
            Console.ReadKey();
        }
    }
}
