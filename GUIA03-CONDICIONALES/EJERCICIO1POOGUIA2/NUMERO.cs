using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO1POOGUIA2
{
	public class NUMERO
	{
		public int LIMITELISTA { get; set; }

		public double[] cantidaddenumeros;
		public NUMERO() { }
		public void asignacionvector()
		{
			bool NEW;
			cantidaddenumeros = new double[this.LIMITELISTA];
			for (int i = 0; i < this.LIMITELISTA; i++)
			{
				Console.WriteLine("BUEN DIA DIGITE LOS NUMEROS");
				NEW = double.TryParse(Console.ReadLine(), out cantidaddenumeros[i]);
			}
		}
		public void visualizacionvector()
		{
			foreach (double item in cantidaddenumeros)
			{
				if (item > 0)
				{
					Console.WriteLine(item);
				}
			}

		}
	}
}
