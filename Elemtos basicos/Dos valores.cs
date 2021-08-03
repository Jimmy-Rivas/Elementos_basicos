using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemtos_basicos
{
    class Dos_valores
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;//Variables a declarar
            Console.WriteLine("ingrese un primer numero");// pide al usuario ingresar el primer numero
            numero1 =
                int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un segundo numero");// segundo numero
            numero2 =
                int.Parse(Console.ReadLine());
            resultado = (numero1 + numero2) * (numero1 - numero2);// Operaciones a realizar 
            Console.WriteLine("El resultado es "+resultado);// muestra el resultado de las operaciones
            Console.ReadLine();
                



        }


    }
}
