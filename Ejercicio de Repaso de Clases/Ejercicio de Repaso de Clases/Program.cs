using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Repaso_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto("Guiller", 666, "Melenudo");
            Producto producto2 = new Producto("La Obituarios",1000000);

            string opcion;

            producto1.Mostrar();
            producto2.Mostrar();
            Console.ReadKey();

            do
            {
                Console.WriteLine("1.Crear Objeto\n2.Hacer Pedido\n3.Mostrar el total+IVA\n4.Salir");
                opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion) 
                {
                    case "1":
                        Console.WriteLine("introduce nombre de producto: ");
                        producto2.Pnombre = Console.ReadLine();
                        Console.WriteLine("Introduce precio: ");
                        producto2.Pprecio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce categoria");
                        producto2.Pcategoria = Console.ReadLine();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Valor no valido");
                        break;

                }
                    
            } while (opcion!="4");
        }
    }
}
