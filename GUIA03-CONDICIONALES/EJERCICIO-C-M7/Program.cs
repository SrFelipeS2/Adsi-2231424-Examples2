using System;

public class Program
{
	public static void Main()
	{
		/*7. El costo de las llamadas internacionales depende de la zona geográfica en la que se encuentre el país destino, 
				y del número de minutos hablados.
				En la siguiente tabla se presenta el costo por minuto por zona. A cada uno se le ha asociado una clave. 
				Construya la solución para calcular e imprimir el costo de una llamada dada la clave y la duración de la llamada.
				Clave   Zona             Precio Precio/minuto(del 4 en adelante)				
				12 		América del Norte 	200 150
				15 		América Central 	220 180
				18 		América del Sur 	450 350
				19 		Europa 				350 270
				23 		Asia 				600 460
				25 		África 				600 460
				29 		Oceanía 			500 390   */
		int clave;
		double minutos, valor;

		Console.WriteLine("Ingrese la clave del pais a llamar: ");
		clave = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese la cantidad de minutos en la llamada: ");
		minutos = double.Parse(Console.ReadLine());

		switch (clave)
		{
			case 12:
				valor = 4 * 200 + (minutos - 4) * 150;
				break;
			case 15:
				valor = 4 * 220 + (minutos - 4) * 180;
				break;
			case 18:
				valor = 4 * 450 + (minutos - 4) * 350;
				break;
			case 19:
				valor = 4 * 350 + (minutos - 4) * 270;
				break;
			case 23:
				valor = 4 * 600 + (minutos - 4) * 460;
				break;
			case 25:
				valor = 4 * 600 + (minutos - 4) * 460;
				break;
			case 29:
				valor = 4 * 500 + (minutos - 4) * 390;
				break;
			default:
				valor = 0;
				Console.WriteLine("Clave errada");
				break;
		}
		Console.WriteLine("El valor a pagar de la llamada es: " + valor);
	}
}
