using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un importe: \n");
            double importe = 0;
            string mensaje = "";
            importe = double.Parse(Console.ReadLine());
            mensaje = importe > (99.9) ? "No se dispone de ese importe"
                : "Se retirará " + importe;
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}
