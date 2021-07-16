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
            C1.Depositar();
            C1.ConsultarDatos();
            Console.ReadLine();
        }
    }
}
