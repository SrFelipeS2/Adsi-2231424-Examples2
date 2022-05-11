using System;
using System.Collections.Generic;
namespace EJERCICIO5POOGUIA2
{
    class Program
    {
			public static void Main(string[] args)
			{

				/*5) Crear una clase Factura con los siguientes atributos:
				- Cedula_usuario, anio, mes, estrato, kwh_consumidos.
				- Realizar constructores y métodos set y get.
				- Crear la función calcularValorFactura, que retorna el valor a pagar de la factura
				dependiendo del estrato y los kwh_consumidos, teniendo en cuenta la siguiente
				información:
				Valor kwh = $580

				Estrato Descuento Contribución
				Estrato 1 y 2 60% 0%
				Estrato 3 y 4 40% 0%
				Estrato 5 y 6 0% 20%
				A partir de la clase creada:
				1. Realizar una aplicación que pida por pantalla la información de las facturas de los
				últimos 5 meses para un usuario e ingresar la información de cada objeto en un vector
				(Vector de facturas).
				2. Mostrar el valor a pagar de las facturas del usuario.
				3. Calcular el promedio de consumo de kwh en los meses 1, 2,3 y 4, si el consumo del
				mes 5 supera el promedio, se cobrará un 10% más sobre el valor de la factura, si el
				consumo es menor o igual a promedio se descuenta un 10%.*/
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
						Console.WriteLine("Digite Nombre");
						nombre = Console.ReadLine();
						Console.WriteLine("Digite la cedula");
						Cedula = long.Parse(Console.ReadLine());
						Console.WriteLine("Digite el año de la factura");
						año = int.Parse(Console.ReadLine());
						Console.WriteLine("Digite el mes");
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
					Console.WriteLine("Digite el estrato de la factura");
					estrato = int.Parse(Console.ReadLine());
					Console.WriteLine("Digite la cantidad de kwh consumidos");
					kwh = int.Parse(Console.ReadLine());

					facturas = new Factura(Cedula, año, mes, estrato, kwh);

					listaFacturas.Add(facturas);

				}


				for (int i = 0; i < 5; i++)

				{
					Console.WriteLine("El total a pagar de la factura " + (i + 1) + " del año " + listaFacturas[i].Año + " mes " + listaFacturas[i].mes + " es de: " + listaFacturas[i].PagoFactura());
					promedio += listaFacturas[i].Kwh;
				}
				promedio = promedio / 5;



				listaFacturas[5].PagoFactura();
				if (listaFacturas[5].Kwh > promedio)
				{
					adicional = listaFacturas[4].PagoFactura() * 0.1;
					totalPagar = listaFacturas[4].PagoFactura() + adicional;
				}
				else
				{
					adicional = listaFacturas[4].PagoFactura() * 0.09;
				}

				Console.WriteLine("El valor a pagar en la factura 5 del año " + listaFacturas[5].Año + " mes " + listaFacturas[4].mes + " es de: " + adicional);
				Console.ReadKey(true);
			}
	}
}

