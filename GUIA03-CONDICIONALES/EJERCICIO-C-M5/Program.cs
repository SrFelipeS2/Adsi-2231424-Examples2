using System;

public class Exercise5
{
	public static void Main()
	{
		//El costo de las llamadas internacionales depende de la zona geográfica en la que se encuentre
		//el país destino,
		//y del número de minutos hablados.
		//En la siguiente tabla se presenta el costo por minuto por zona. A cada uno se le ha asociado una clave.

		//Clave       Zona               Precio
		//12   América del Norte          200
		//15   América Central            220
		//18   América del Sur            450
		//19       Europa                 350
		//23        Asia                  600
		//25       África                 600
		//29       Oceanía                500

		int minutos,Clave;
		double total=0;
		Console.WriteLine("ingrese la cantidad de minutos");
		minutos = int.Parse(Console.ReadLine());
		Console.WriteLine("ingrese la contraseña de su pais:  ");
		Clave = int.Parse(Console.ReadLine());

		switch (Clave)
		{
			case 12:
				total = minutos * 200;
				 break;
			case 15:
				total = minutos * 220;
			    break;
			case 18:
				total = minutos * 450;
				 break;
			case 19:
				total = minutos * 350;
				 break;
			case 23:
				total = minutos * 600;
				 break;
			case 25:
				total = minutos * 600;
				break;
			case 29:
				total = minutos * 500;
			    break;
		}
		Console.WriteLine("total minutos hablados es : " + minutos);
		Console.WriteLine("el total a pagar por los minutos hablados es de: $ " + total);
	}
}
