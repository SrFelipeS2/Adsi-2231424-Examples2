using System;

namespace ejercicio1
{
	class Program
	{
		static void Main(string[] args)
		{
			string nombre;
			double salario_neto, horas_trabajadas, valor_hora, incentivo;

			Console.WriteLine("Digite su nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("Digite horas trabajadas");
			horas_trabajadas = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de las horas");
			valor_hora = double.Parse(Console.ReadLine());

			salario_neto = horas_trabajadas * valor_hora;

			if (horas_trabajadas > 40)
			{
				incentivo = salario_neto * 0.05;
				salario_neto = salario_neto + incentivo;
			}

			Console.WriteLine("El nombre el empleado es:" + nombre);
			Console.WriteLine("El salario neto del empleado es: " + salario_neto);
		}
	}
}