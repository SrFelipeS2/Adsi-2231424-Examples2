using System;

namespace EJERCICIO1POOGUIA2
{
    class Program
    {
		public static void MainT(string[] args)
		{
			NUMERO numeros1 = new NUMERO();
			int espaciovector;
			bool NEW;
			Console.WriteLine("CUANTOS NUMEROS VA A INGRESAR");
			NEW = int.TryParse(Console.ReadLine(), out espaciovector);
			numeros1.LIMITELISTA = espaciovector;
			numeros1.asignacionvector();
			numeros1.visualizacionvector();

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
