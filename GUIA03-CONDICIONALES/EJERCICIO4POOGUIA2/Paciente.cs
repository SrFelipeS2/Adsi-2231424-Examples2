using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO4POOGUIA2
{
    class Paciente
    {
		/*Atributos: nombres, apellidos, género, cedula, tipoSangre, eps, edad, codigoPaciente
(alfanumérico).*/
		private string nombre;
		private string apellido;
		private char genero;
		private long cedula;
		public string TipoSangre { get; set; }
		public string Eps { get; set; }
		public int Edad { get; set; }
		private string codigoPaciente;

		public Paciente()
		{

		}

		public Paciente(string _nombre, string _apellido, char _genero, int _edad, long _cedula)
		{

			this.nombre = _nombre;
			this.apellido = _apellido;
			this.genero = _genero;
			this.Edad = _edad;
			this.cedula = _cedula;
			generarCodigo();
		}

		public Paciente(string _nombre, string _apellido, char _genero, int _edad, long _cedula, string _tipoSangre, string _eps)
		{

			this.nombre = _nombre;
			this.apellido = _apellido;
			this.genero = _genero;
			this.Edad = _edad;
			this.cedula = _cedula;
			this.TipoSangre = _tipoSangre;
			this.Eps = _eps;
			generarCodigo();
		}


		public void setNombre(string _nombre)
		{
			this.nombre = _nombre;
		}
		public string getNombre()
		{
			return this.nombre;
		}

		public string Apellido
		{
			get { return this.apellido; }
			set { this.apellido = value; }
		}
		public char Genero
		{
			get { return this.genero; }
			set { this.genero = value; }
		}
		public long Cedula
		{
			get { return this.cedula; }
			set { this.cedula = value; }
		}
		public string getCodigoPasiente()
		{
			while (this.codigoPaciente == null)
			{
				generarCodigo();
			}
			return this.codigoPaciente;
		}


		public bool calculoHombreMayor()
		{
			if ((this.Edad >= 18 && this.genero == 'm') || (this.Edad >= 18 && this.genero == 'M'))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void generarCodigo()
		{
			int codigo;
			Random numero = new Random();
			codigo = numero.Next(1000, 10000);
			this.codigoPaciente = this.Cedula + "." + codigo;
		}

	}

}
