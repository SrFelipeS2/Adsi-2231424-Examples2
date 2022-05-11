using System;

public class Program
{
	public static void Main()
	{
		/*ejercicio 3 El jefe de un almacén de ropa, pone una promoción en sus trajes por un período de tres días para
sus clientes, de tal manera que si un cliente ordena un traje se captura el modelo del traje y el
precio unitario. Si el cliente ordena tres o más trajes se le hace un descuento del 17%, si no se le
cobra al precio normal. Desarrollar el algoritmo y diagrama de flujo.*/
		string marca;
		double precioT, descuento, precio;
		int trajes;
		Console.WriteLine("Digite el modelo del traje");
		marca = Console.ReadLine();
		Console.WriteLine("Digite el precio unitario del traje");
		precio = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite cuantos trajes desea llevar");
		trajes = int.Parse(Console.ReadLine());
		precioT = trajes * precio;
		if (trajes >= 3)
		{
			descuento = precioT * 0.17;
			precioT = precioT - descuento;
		}
		Console.WriteLine("El precio total es de: " + precioT);
	}
}