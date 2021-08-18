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
            Cliente prueba = new Cliente("Willer","Iglesias","documento","Metalero","");
            prueba.generarCodigo();
            Console.WriteLine(prueba.Pcodigo);

            Empleado probado = new Empleado("Charmander", "José","007","F",500);
            probado.calcularSueldo();
            Console.WriteLine("\nEl empleado "+probado.Pnombres+" "+probado.Papellidos+" tiene un sueldo de "+probado.Psueldo);

            Empleado probado1 = new Empleado("Escuero", "José", "007", "T", 500);
            probado1.calcularSueldo();
            Console.WriteLine("\nEl empleado " + probado1.Pnombres + " " + probado1.Papellidos + " tiene un sueldo de " + probado1.Psueldo);
            probado.calcularSueldo();
            Empleado probado2 = new Empleado("obituarios", "ded", "8764521", "", 500);
            Console.WriteLine("\nEl empleado " + probado2.Pnombres + " " + probado2.Papellidos + " tiene un sueldo de " + probado2.Psueldo);
            Console.ReadKey();
        }
    }
}
