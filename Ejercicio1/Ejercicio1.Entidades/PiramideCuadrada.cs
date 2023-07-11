using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    public class PiramideCuadrada
    {
		//Crear la clase Pirámide Cuadrada que tiene como atributos lado de la base, la altura y las aristas laterales.
		private int _ladoBase;
		private int _Altura;
		private int _AristaLateral;

		public int AristaLateral
		{
			get { return _AristaLateral; }
			set	{ _AristaLateral = value; }
		}


		public int Altura
		{
			get { return _Altura; }
			set	{ _Altura = value; }
			
		}


		public int LadoBase
		{
			get { return _ladoBase; }
			set	{ _ladoBase = value; }
        }
		public PiramideCuadrada(int aristaLateral, int altura, int ladoBase)
		{
			try
			{
				_AristaLateral = aristaLateral;
				_Altura = altura;
				_ladoBase = ladoBase;
			}
			catch (Exception ex)
			{
				throw;//Console.WriteLine(ex.Message);
			}
		}
		public bool validar()
		{
			if(_AristaLateral>0 && _ladoBase>0 && _Altura > 0)
			{
				return true;
			}
			else
			{
				Console.WriteLine("Los valores proporcionados deben ser mayores a cero");
				return false;
			}
		}
		public double Area() => _ladoBase * (_ladoBase + Math.Sqrt(4 * Math.Pow(_Altura, 2) + Math.Pow(_ladoBase, 2)));
		
		public double Volumen()
		{
			return (Math.Pow(_ladoBase, 2) * _Altura) / 3;
		}
		public override string ToString()
		{
			return $"La piramide cuadrada con su:\nLado de la base={LadoBase}\nAltura={Altura}\nArista lateral={AristaLateral}\n Su area={Area()}\nSu Volumen={Volumen()}\n";
		}
	}
}
