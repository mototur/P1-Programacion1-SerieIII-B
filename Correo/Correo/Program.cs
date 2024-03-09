using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su dirreccion de correo");
            string correo = Console.ReadLine();

            string nombre = correo.Substring(0, correo.IndexOf("@"));
            string dominioActual = correo.Substring(correo.IndexOf("@") + 1);

            Console.WriteLine("Introduzca el dominio nuevo: ");
            string DominioNuevo = Console.ReadLine();

            string CorreoNuevo = nombre + "@" + DominioNuevo;

            Console.WriteLine("Su dirreccion de correo se ha cambiado es: " + CorreoNuevo);
        }
    }
}
