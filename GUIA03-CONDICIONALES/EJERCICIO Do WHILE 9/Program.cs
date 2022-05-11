using System;

namespace EJERCICIO_Do_WHILE_9
{
	class Program
	{
		static void Main(string[] args)
		{
			int opcion, radianes, grados;
			double PI = 3.1415927, totalRadianes, totalGrados;
			bool validar;
			do
			{
				Console.WriteLine("Ingrese una Opcion:");
				Console.WriteLine("1. Pasar de grados a radianes");
				Console.WriteLine("2. Pasar de radianes a grados");
				Console.WriteLine("3. Salir del programa");
				validar = int.TryParse(Console.ReadLine(), out opcion);

				if (opcion == 1)
				{
					Console.WriteLine("Ingrese la cantidad de grados");
					validar = int.TryParse(Console.ReadLine(), out grados);

					totalRadianes = grados * PI / 180;
					Console.WriteLine("El total de radianes es: " + totalRadianes);
				}
				else if (opcion == 2)
				{
					Console.WriteLine("Ingrese la cantidad de radianes");
					validar = int.TryParse(Console.ReadLine(), out radianes);

					totalGrados = (radianes * 180) / PI;
					Console.WriteLine("El total de grados es: " + totalGrados);
				}
				



			} while (opcion != 3);
		}
	}
}