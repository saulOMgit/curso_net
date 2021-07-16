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
            Insecto I1 = new Insecto("Hormiga", "Beru", 90, 0, true);
            A1.QueClaseDeAnimalEres();
            Console.WriteLine();
            P1.QueClaseDeAnimalEres();
            Console.WriteLine();
            I1.QueClaseDeAnimalEres();
            Console.ReadLine();
        }
    }
}
