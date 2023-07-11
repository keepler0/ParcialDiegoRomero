using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Entidades
{
    public class Fahrenheit
    {
		private float _grado;

		public float Grado
		{
			get { return _grado; }
			set { _grado = value; }
		}
		public Fahrenheit()
		{
			_grado = 0;
		}
		public Fahrenheit(int grado)
		{
			_grado = grado;
		}
	}
}
