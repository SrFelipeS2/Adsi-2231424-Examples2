using System;

public class Program
{
	public static void Main()
	{
		/*7- Una compañía de seguros esta abriendo un depto. de finanzas y estableció un programa para captar
clientes, que consiste en lo siguiente: Si el monto por el que se efectúa la fianza es menor que $50
000 la cuota a pagar será por el 3% del monto, y si el monto es mayor que $50 000 la cuota a pagar
será el 2% del monto. La compañia desea determinar cual será la cuota que debe pagar un cliente.*/

		double finanza, cuota;
		Console.WriteLine("Digite el valor de la finanza");
		finanza = double.Parse(Console.ReadLine());
		cuota = finanza * 0.03;
		if (finanza >= 50000)
		{
			cuota = finanza * 0.02;
		}
		Console.WriteLine("La cuota a pagar es de: " + cuota);
	}
}
