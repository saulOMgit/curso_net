using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RepasoDeMañanaDia27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coche lere = new Coche(001, "BMW", "X4", 10000, 500000, true);
            //lere.ListarCoche();
            //Console.ReadKey();
            Coche Coche1 = new Coche();
            Moto Moto1 = new Moto();
            string opcion;

            do
            {
                Console.WriteLine("Pulse:\n1.Para crear Coche\n2.Para crear Moto\n3.Para listar Coche\n4.Para listar Moto\n5.Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Introduce ID;");
                        Coche1.PID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce Marca:");
                        Coche1.PMarca = Console.ReadLine();
                        Console.WriteLine("Introduce Modelo:");
                        Coche1.PModelo = Console.ReadLine();
                        Console.WriteLine("Km Recorridos:");
                        Coche1.PKM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce Precio:");
                        Coche1.PPrecio = double.Parse(Console.ReadLine());
                        Console.WriteLine("¿Tiene Airbag? S/N");
                        string opcionairbag = Console.ReadLine();
                        if (opcionairbag == "S" || opcionairbag == "s") 
                        { Coche1.PAirbag = true; }
                        else { Coche1.PAirbag = false; }
                        break;
                    case "2":
                        Console.WriteLine("Introduce ID;");
                        Moto1.PID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce Marca:");
                        Moto1.PMarca = Console.ReadLine();
                        Console.WriteLine("Introduce Modelo:");
                        Moto1.PModelo = Console.ReadLine();
                        Console.WriteLine("Km Recorridos:");
                        Moto1.PKM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce Precio:");
                        Moto1.PPrecio = double.Parse(Console.ReadLine());
                        Console.WriteLine("¿Tiene Airbag? S/N");
                        string opcionsidecar = Console.ReadLine();
                        if (opcionsidecar == "S" || opcionsidecar == "s")
                        { Moto1.PSidecar = true; }
                        else { Moto1.PSidecar = false; }
                        break;
                    case "3":
                        Coche1.ListarCoche();
                        break;
                    case "4":
                        Moto1.ListarMoto();
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
