using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO5POOGUIA2
{
    class Factura
	{
		// atributos
		// atributos
		public string Nombre { get; set; }
		private long Cedula_usuario;
		public int Año { get; set; }
		private double kwh_consumidos;
		public int Estrato { get; set; }
		public int mes { get; set; }
		private double valorFactura;
		private double contribucion;

		public Factura(long Cedula, int año, int mes, int estrato, int kwh)
		{
			this.Cedula = Cedula;
			this.Año = año;
			this.mes = mes;
			this.Estrato = estrato;
			this.kwh_consumidos = kwh;
		}

		public long Cedula
		{
			set { this.Cedula_usuario = value; }
			get { return this.Cedula_usuario; }
		}

		public double Kwh
		{
			set { this.kwh_consumidos = value; }
			get { return this.kwh_consumidos; }
		}

		public double PagoFactura()
		{
			double descuentoFac;

			if (this.Estrato == 1 || this.Estrato == 2)
			{
				descuentoFac = this.kwh_consumidos * 580 * 0.60;
				valorFactura = this.kwh_consumidos * 580 - descuentoFac;
			}

			else if (this.Estrato == 3 || this.Estrato == 4)
			{
				descuentoFac = this.kwh_consumidos * 580 * 0.40;
				valorFactura = this.kwh_consumidos * 580 - descuentoFac;
			}
			else if (this.Estrato == 5 || this.Estrato == 6)
			{
				contribucion = this.kwh_consumidos * 580 * 0.2;
				valorFactura = this.kwh_consumidos * 580 + contribucion;
			}
			return valorFactura;
		}

	}
}
