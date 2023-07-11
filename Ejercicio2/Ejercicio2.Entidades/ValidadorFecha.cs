using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entidades
{
    public static class ValidadorFecha
    {
        /*2. Crear la clase estática ValidadorFecha que tiene un único método público Validar que recibe 3 parámetros
        de tipo entero, Dia, Mes y Anio, y debe informar si los mismos conforman una fecha válida o no.
        a. Debe tener un método privado para determinar si un año es bisiesto:
        i. Un año es bisiesto si es divisible por 4, excepto los divisibles por 100 que no son bisiestos,
        excepto los divisibles por 400 que sí lo son.

        b. Usar la clase en un programa de consola para probar su funcionalidad.*/
        public static bool Validar(int Dia,int Mes,int Anio)
        {
            if (Dia<31 && Mes<12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void anioBisiesto(int Anio)
        {
            if (Anio%4==0 && Anio%100!=0 || Anio%400==0) 
            {
                Console.WriteLine($"{Anio} es Bisiesto");
            }
            else
            {
                Console.WriteLine($"{Anio} no es Bisiesto");
            }
        }

    }
}
