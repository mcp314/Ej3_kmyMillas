using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kilometro;
using Milla;

namespace Ej3_kmyMillas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrece el valor de velocidad");
            var kilometros = new Kilometros();
            double valor = Double.Parse(Console.ReadLine());
            kilometros.setVelocidad(valor);
            Console.WriteLine($"La velocidad es {kilometros.getVelocidad(kilometros)}");

            var kilometro2 = new Kilometros();
            Console.WriteLine($"La velocidad por defecto es {kilometro2.getVelocidad(kilometro2)}");









            Console.ReadLine();

        }
    }
}
