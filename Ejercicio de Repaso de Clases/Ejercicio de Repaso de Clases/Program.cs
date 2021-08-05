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
            Producto producto2 = new Producto();

            string opcion;
            double total=0;
            double cantidad = 0;
            double cantidadtotal = 0;

            producto1.Mostrar();

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
                        producto2.Mostrar();
                        break;
                    case "2":
                        Console.WriteLine("Cuantas unidades deseas?");
                        cantidad =double.Parse(Console.ReadLine());
                        cantidadtotal = cantidadtotal + cantidad;
                        double precio = producto2.Pprecio;
                        precio = precio * cantidad;
                        total = total + precio;
                        Console.WriteLine("Ha comprado "+cantidadtotal+" "+producto2.Pnombre+" por "+total+" euros");
                        break;
                    case "3":
                        double iva = 0;
                        Console.WriteLine("Introduce el IVA:");
                        iva = int.Parse(Console.ReadLine());
                        iva = iva / 100;
                        double totaliva = 0;
                        totaliva = total + (total * iva);
                        Console.WriteLine("Son " + totaliva + " euros por favor \n En metalico o con tarjeta o con tarjeta de credito de El Corte Inglés");
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Valor no valido");
                        break;

                }
                    
            } while (opcion!="4");
            Console.WriteLine("Que tenga un buen dia");
            Console.ReadLine();
        }
    }
}
