using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Entidades
{
    public class Kelvin
    {
		private float _grado;

		public float Grado
		{
			get { return _grado; }
			set { _grado = value; }
		}
		public Kelvin()
		{
			_grado = 0;
		}
		public Kelvin(int grado)
		{
			_grado = grado;
		}
	}
}
