using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Entidades
{
    public class Celsius
    {
		/*3. Crear las clases Celsius, Kelvin y Fahrenheit con las siguientes características:
		a. Cada clase tiene 1 un atributo privado _grados de tipo float.
		b. Las clases deben tener un método para informar dicho atributo.
		c. Deberán tener 2 constructores uno donde se proporciona el valor del atributo _grados y otro sin
		atributos que por defecto inicializa el atributo en 0
		d. Hacer la sobrecarga implícita entre float y las temperaturas.
		e. Hacer la sobrecarga explícita entre las temperaturas.
		f. Sobrecargar los operadores de igualdad en las temperaturas. Los operadores de comparación ==
		compararán los valores de los atributos de las clases.
		g. Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con
		total normalidad como si fueran tipos numéricos, teniendo en cuenta las siguientes equivalencias:
		i. F = C * (9/5) + 32
		ii. K=C+273.15
		iii. C = (F-32) * 5/9
		iv. F = K * 9/5 – 459.67
		v. K = (F + 459.67) * 5/9*/
		private float _grado;

		public float Grado
		{
			get { return _grado; }
			set { _grado = value; }
		}
		public Celsius()
		{
			_grado = 0;
		}
		public Celsius(int grado)
		{
			_grado = grado;
		}
	}
}
