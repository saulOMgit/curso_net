using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoConsola
{
    class Program
    {
        //Ejercicio para gestionar las cuentas de un banco
        //Se pide crear una clase de tipo cuenta para gestionar ingresos y gastos
        static void Main(string[] args)
        {
            Cuenta C1 = new Cuenta(007,"Frodo",1000);
            int opcion=0;
            do
            {
                Console.WriteLine("1.Crear Cuenta\n2.Depositar una cantidad\n3.Retirar Dinero\n4.Consultar Saldo\n5.Salir de la App");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Introduce número de cuenta:");
                        C1.PNumeroCuenta = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce Nombre del titular:");
                        C1.PNombreCliente = Console.ReadLine();
                        Console.WriteLine("Introduce sueldo inicial");
                        C1.PSaldo = double.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();
                        C1.Depositar();
                        break;
                    case 3:
                        Console.Clear();
                        C1.Retirar();
                        break;
                    case 4:
                        Console.Clear();
                        C1.ConsultarDatos();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Que tenga un buen dia");
                        break;
                    default:
                        Console.WriteLine("Valor incorrecto");
                        break;
                }   
            } while (opcion != 5);

            Console.ReadLine();
        }
    }
}
