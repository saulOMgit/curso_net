using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiestaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es de prueba, no mirar
            //FiestaDeGala Cler = new FiestaDeGala(21, 0, 0, 20, true,0,true);
            //Cler.CalcularCostoDeDecoracion();
            //Cler.CalcularCosto();
            //Console.ReadKey();
            //Console.Clear();
            string opcion;
            


            do
            {
                Console.WriteLine("¿Que fiesta desea?\n1.Fiesta VIP\n2.Fiesta de Cumpleaños\n3.Salir.");
                opcion=Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        FiestaDeGala VIP = new FiestaDeGala();
                        Console.WriteLine("¿Cuantas personas asistiran?");
                        VIP.PNumeroDePersonas = int.Parse(Console.ReadLine());
                        Console.Clear();
                        //Console.WriteLine("BONO EXTRA");
                        //VIP.PbonoExtra = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿De que valor sera la comida por persona?");
                        VIP.PCostodeComidaPorPersona = int.Parse(Console.ReadLine());
                        Console.Clear();
                        string decoracion;

                        Console.WriteLine("Si desea decoracion pulse 1 si no pulse 2");
                        decoracion = Console.ReadLine();

                        switch (decoracion)
                        {
                            case "1":
                                VIP.PDecora = true;
                                break;
                            case "2":
                                VIP.PDecora = false;
                                break;
                        }
                        Console.Clear();
                        VIP.SetOpcionEXTRA();
                        VIP.CalcularCostoDeDecoracion();
                        VIP.CalcularCosto();


                        break;
                    case "2":
                        FiestaDeCumpleaños Cumple = new FiestaDeCumpleaños();
                        Console.WriteLine("¿Cuantas personas asistiran?");
                        Cumple.PNumeroDePersonas = int.Parse(Console.ReadLine());
                        Console.Clear();
                        //Console.WriteLine("BONO EXTRA");
                        //Cumple.PbonoExtra = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿De que valor sera la comida por persona?");
                        Cumple.PCostodeComidaPorPersona = int.Parse(Console.ReadLine());
                        Console.Clear();
                        string decoracioncumple;

                        Console.WriteLine("Si desea decoracion pulse 1");
                        decoracioncumple = Console.ReadLine();

                        switch (decoracioncumple)
                        {
                            case "1":
                                Cumple.PDecora = true;
                                break;
                            case "2":
                                Cumple.PDecora = false;
                                break;
                        }
                        Console.Clear();
                        Cumple.CalcularCostoDeDecoracion();
                        Cumple.CalcularCosto();
                        break;

                    case "3":
                        Console.WriteLine("Esperamos volver a verle");
                        break;
                    default:
                        Console.WriteLine("Valor no válido");
                        break;
                }
            } 
            while (opcion != "3");
        }
    }
}
