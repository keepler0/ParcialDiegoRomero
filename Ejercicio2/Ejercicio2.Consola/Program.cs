using Ejercicio2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int Dia;
                int Mes;
                int Anio;
                int seleccionar;
                Console.WriteLine("Ingrese una fecha: ");
                Console.Write("Dia="); Dia = Validar();
                Console.Write("Mes="); Mes = Validar();
                Console.Write("Año="); Anio = Validar();

                if (ValidadorFecha.Validar(Dia, Mes, Anio))
                {
                    Console.WriteLine($"Fecha ingresada: {Dia}/{Mes}/{Anio}");
                }
                else
                {
                    Console.WriteLine("Los valores proporcionados no conforman una fecha");
                    Console.WriteLine("Intentelo de nuevo:");
                }
                Console.WriteLine("Desea realizar otra operacion? 1=si 2=no");
                do
                {
                    seleccionar = Validar();
                    if (seleccionar == 1)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (seleccionar==2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("procure seleccionar 1=Realizar otra operacion o 2= para cerrar");
                    }
                } while (true);

            } while (true);
        }

        private static int Validar()
        {
            int numero;
            do
            {
                string valor = Console.ReadLine();
                if (int.TryParse(valor,out numero))
                {
                    break;
                }
                Console.WriteLine("El valor proporcionado es erroneo...intentelo de nuevo=");
            } while (true);
            return numero;
        }
    }
}
