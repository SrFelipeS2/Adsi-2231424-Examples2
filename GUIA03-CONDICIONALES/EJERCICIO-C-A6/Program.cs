using System;

public class Program
{
	public static void Main()
	/*6. El dueño de una empresa desea planificar las decisiones financieras que tomara en el Siguiente año. La manera
de planificarlas depende de lo siguiente:
Si actualmente su capital se encuentra con saldo negativo, pedirá un préstamo bancario para que su nuevo
saldo sea de $1000000. Si su capital tiene actualmente un saldo positivo pedirá un préstamo bancario para
tener un nuevo saldo de $2000000, pero si su capital tiene actualmente un saldo superior a los $2000000 no
pedirá ningún préstamo.
Posteriormente repartirá su presupuesto de la siguiente manera.
• $500000 para equipo de computo
• $200000 para mobiliario
• y del resto, la mitad será para la compra de insumos y la otra para otorgar incentivos al personal.
Solicitar el capital y en base a este desplegar que cantidades se destinaran para la compra de insumos e
incentivos al personal y, en caso de que fuera necesario, a cuanto ascendería la cantidad que se pediría al
banco.

*/
	{
		double S, P = 0, SN;
		Console.WriteLine("diguite su saldo");
		S = double.Parse(Console.ReadLine());
		if (S < 0)
		{
			P = 1000000 - S;
			SN = P + S;
		}
		else if (S < 2000000)
		{
			P = 2000000 - S;
			SN = P + S;
		}
		else { SN = S; }
		Console.WriteLine("El presupuesto se repartirá de la siguiente manera:");
		Console.WriteLine("Para equipo de cómputo: $500000");
		Console.WriteLine("Para mobiliario: $200000");
		SN = SN - 700000;
		Console.WriteLine("Para la compra de insumos: $" + SN / 2);
		Console.WriteLine("Para incentivos: $" + SN / 2);
		Console.WriteLine("EL prestamo que se pidio al banco es: $" + P);

	}
}