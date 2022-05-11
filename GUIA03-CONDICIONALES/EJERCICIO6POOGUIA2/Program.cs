using System;
using System.Collections.Generic;
namespace EJERCICIO6POOGUIA2
{
    class Program
    {
		public static void Main(string[] args)
		{
			string nombre = "";
			long Cedula = 0;
			int año = 0, estrato = 0, cantidad = 0, kwh = 0, mes = 0;
			double promedio = 0, adicional = 0, totalPagar = 0;
			Factura facturas;
			Factura[] factura = new Factura[5];
			List<Factura> listaFacturas = new List<Factura>();

			for (int i = 0; i < factura.Length; i++)
			{
				if (i == 0)
				{
					Console.Write("\nDigite su nombre: ");
					nombre = Console.ReadLine();
					Console.Write("Digite su cedula: ");
					Cedula = long.Parse(Console.ReadLine());
					Console.Write("Digite el año de la factura: ");
					año = int.Parse(Console.ReadLine());
					Console.Write("Digite el mes: ");
					mes = int.Parse(Console.ReadLine());
				}
				else
				{
					if (mes < 12)
					{
						mes++;
					}
					else if (mes == 12)
					{
						mes = 1;
						año++;
					}
				}
				Console.Write("ingrese el estrato de la factura: ");
				estrato = int.Parse(Console.ReadLine());
				Console.Write("ingrese la cantidad de kwh consumidos: ");
				kwh = int.Parse(Console.ReadLine());

				facturas = new Factura(Cedula, año, mes, estrato, kwh);

				listaFacturas.Add(facturas);

			}

			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("El total a pagar de la factura " + (i + 1) + " del año " + listaFacturas[i].Año + " mes " + listaFacturas[i].mes + " es de: " + listaFacturas[i].PagoFactura());
				promedio += listaFacturas[i].Kwh;
			}
			promedio = promedio / 4;

			listaFacturas[4].PagoFactura();
			if (listaFacturas[4].Kwh > promedio)
			{
				adicional = listaFacturas[4].PagoFactura() * 0.1;
				totalPagar = listaFacturas[4].PagoFactura() + adicional;
			}
			else
			{
				adicional = listaFacturas[4].PagoFactura() * 0.09;
			}

			Console.WriteLine("El valor a pagar en la factura 5 del año " + listaFacturas[4].Año + " mes " + listaFacturas[4].mes + " es de: " + adicional);
			Console.ReadKey(true);
		}
	}
}
