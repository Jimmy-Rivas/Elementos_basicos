using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemtos_basicos
{
    class Grados
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese grados centigrados");// grados que se desean calcular
            Double c =
                Convert.ToDouble(Console.ReadLine());
            Double F = (c*9/5)+(32);// operacion para obtener resultado

            Console.WriteLine(c + "°C es eqeuivalente a " + F + "°F");// muestra resultado 
            Console.ReadLine();
        }



    }
}
