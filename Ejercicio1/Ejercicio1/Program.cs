using Ejercicio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoBase;
            int altura;
            int aristaLateral;
            int seleccionar;
            
            do
            {
                Console.WriteLine("Se creara onjetos de tipo PiramideCuadrada y se informará sus datos como el Area y volumen del mismo");
                Console.Write("Ingrese el Lado de la Base=");
                ladoBase = Validar();
                Console.Write("Ingrese la Altura=");
                altura = Validar();
                Console.Write("Ingrese la Arista lateral=");
                aristaLateral = Validar();
                var p = new PiramideCuadrada(aristaLateral, altura, ladoBase);
                Console.WriteLine(p.ToString());
                Console.WriteLine("Desea relializar otra operacion? 1=si 2=no");
                do
                {
                    seleccionar = Validar();
                    if (seleccionar == 1)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (seleccionar == 2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Procure seleccionar 1=realizar otra operacion 2= para cerrar");
                    }

    } while (true);
            } while (true);
        }

        private static int Validar()
        {
            int num;
            do
            {
                string dato = Console.ReadLine();
                if (!int.TryParse(dato,out num))
                {
                    Console.WriteLine("El dato proporcionado es invalido....intentelo de nuevo=");
                }
                else
                {
                    break;
                }
            } while (true);
            return num;
        }
    }
}
