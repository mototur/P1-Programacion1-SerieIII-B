using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III__parcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenida");
            Console.WriteLine("Ingrese primer precio");
            int precioUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo precio");
            int precioDos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer precio");
            int precioTres = int.Parse(Console.ReadLine());
            Calculo(precioUno, precioDos, precioTres);
            Console.ReadKey(true);
        }
        public static void Calculo (int precioUno, int precioDos, int precioTres)
        {

        }
    }
}
