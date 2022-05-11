using System;

public class Program
{
	public static void Main()
	/*4. En un montallantas se ha establecido una promoción de las llantas marca “Ponchadas”, dicha promoción
consiste en lo siguiente:
Si se compran menos de cinco llantas el precio es de $90000 cada una, de $80000 si se compran de cinco a 10
y de $70000 si se compran más de 10. Obtener la cantidad de dinero que una persona tiene que pagar por cada
una de las llantas que compra y la que tiene que pagar por el total de la compra*/
	{
		int cantNeumaticos, MENOR5, CINCOADIEZ, MAYOR10, total;
		Console.WriteLine("Ingrese cantidad de llantas a comprar");
		cantNeumaticos = int.Parse(Console.ReadLine());
		MENOR5 = 90000;
		CINCOADIEZ = 80000;
		MAYOR10 = 70000;
		if (cantNeumaticos < 5)
		{
			total = cantNeumaticos * MENOR5;
			Console.WriteLine("El valor por cada llanta (ponchada) es: $" + MENOR5);
		}
		else if (cantNeumaticos >= 5 && cantNeumaticos <= 10)
		{
			total = cantNeumaticos * CINCOADIEZ;
			Console.WriteLine("El valor por cada llanta (ponchada) es: $" + CINCOADIEZ);
		}
		else
		{
			total = cantNeumaticos * MAYOR10;
			Console.WriteLine("El valor por cada llanta (ponchada) es: $" + MAYOR10);
		}
		Console.WriteLine("El valor total a pagra es: $" + total);
	}
}