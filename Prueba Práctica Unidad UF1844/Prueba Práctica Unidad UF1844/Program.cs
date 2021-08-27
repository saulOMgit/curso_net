using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Prueba_Práctica_Unidad_UF1844
{
    class Program
    {
        static void Main(string[] args)
        {
            Turismo Turismo1 = new Turismo(12000, 10000, "SIMCA 1000", true);
            Camion Camion1 = new Camion(82000,50000,"IVECO",15);
            string opcion;
            do
            {
                Console.WriteLine("Pulse:\n1.Para crear Turismo\n2.Para crear Camion\n3.Para listar Turismo\n4.Para listar Camion\n5.Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Introduce precio venta;");
                        Turismo1.PPrecioVenta = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce precio fabrica:");
                        Turismo1.PCostoFabrica = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce Modelo:");
                        Turismo1.PNombreVehiculo = Console.ReadLine();
                        Console.WriteLine("¿Es Clasico? S/N");
                        string opcionclasico = Console.ReadLine();
                        if (opcionclasico == "S" || opcionclasico== "s")
                        { Turismo1.PClasico = true; }
                        else { Turismo1.PClasico = false; }
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Introduce precio venta;");
                        Camion1.PPrecioVenta = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce precio fabrica:");
                        Camion1.PCostoFabrica = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce Modelo:");
                        Camion1.PNombreVehiculo = Console.ReadLine();
                        Console.WriteLine("Introduce tonelaje");
                        Camion1.PToneladas = double.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Turismo1.ListarTurismo();
                        break;
                    case "4":
                        Console.Clear();
                        Camion1.ListarCamion();
                        break;
                    case "5":
                        Console.WriteLine("Gracias por utilizar nuestros servicios\nVuelva pronto");
                        Thread.Sleep(2000);
                        break;
                    default:

                        break;

                }

            } while (opcion != "5");
        }
    }
}
