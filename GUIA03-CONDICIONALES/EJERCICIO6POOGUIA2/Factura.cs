using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO6POOGUIA2
{
    class Factura
	{
		public string Nombre { get; set; }
		private long CedulaUS;
		public int Año { get; set; }
		private double kwh_consumidos;
		public int Estrato { get; set; }
		public int mes { get; set; }
		private double valorFac;
		private double contribu;

		public Factura(long Cedula, int año, int mes, int estrato, int kwh)
		{
			this.CedulaUS = Cedula;
			this.Año = año;
			this.mes = mes;
			this.Estrato = estrato;
			this.kwh_consumidos = kwh;
		}

		public long Cedula
		{
			set { this.CedulaUS = value; }
			get { return this.CedulaUS; }
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
				valorFac = this.kwh_consumidos * 580 - descuentoFac;
			}

			else if (this.Estrato == 3 || this.Estrato == 4)
			{
				descuentoFac = this.kwh_consumidos * 580 * 0.40;
				valorFac = this.kwh_consumidos * 580 - descuentoFac;
			}
			else if (this.Estrato == 5 || this.Estrato == 6)
			{
				contribu = this.kwh_consumidos * 580 * 0.2;
				valorFac = this.kwh_consumidos * 580 + contribu;
			}
			return valorFac;
		}


	}
}

