using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero A1 = new Mamifero("Tigre", "Ryu", 200, 2);
            Ave P1 = new Ave("Agapornis", "Ernesto", 0.02, 3,"Amarillo",100);
            A1.QueClaseDeAnimalEres();
            P1.QueClaseDeAnimalEres();
            Console.ReadLine();
        }
    }
}
