using System;

namespace EJERCICIO4POOGUIA2
{
    class Program
    {
		public static void Main(string[] args)
		{
			/*4) Realizar la clase Paciente:
1. Atributos: nombres, apellidos, género, cedula, tipoSangre, eps, edad, codigoPaciente
(alfanumérico). Estos atributos no deben accederse directamente por lo tanto se les
debe poner el modificador de acceso adecuado.
2. Se deben crear 3 constructores:
- Constructor por defecto.
- Constructor con los atributos nombres, apellidos, género, edad y cedula.
- Constructor con todos los atributos como parámetro.
3. Se deberán crear los métodos get y set para los atributos.
4. Se deben implementar los siguientes métodos:
- Método que devuelve un valor booleano que indica si el paciente es hombre y si es
mayor de edad.
- Método que genere un código aleatorio de 4 cifras, el cual se deberá concatenar
con la cédula del usuario. Este método será invocado cuando se construya el objeto

y se asignará al atributo codigoPaciente del objeto. Este método no deberá ser
visible desde afuera de la clase.
5. Crear 3 instancias de la clase anterior:
- El primer objeto se debe crear con todos los atributos.
- El segundo solo con nombres, apellidos, género, edad y cedula.
- El tercer objeto se debe crear con el constructor por defecto y para este usar los
métodos set para asignar a los atributos un valor.
Se debe indicar para cada uno de los objetos si es hombre y mayor de edad y mostrar
para cada objeto su información, incluyendo el código generado por el sistema.*/
			string nombre, apellido, tiposSan, eps;
			char genero;
			long cedula;
			int edad;

			//Paciente paciente1;

			Console.WriteLine("Digite el nombre del paciente 1: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese los apellidos del paciente 1: ");
			apellido = Console.ReadLine();
			Console.WriteLine("Digite el tipo de sangre del paciente 1 : ");
			tiposSan = Console.ReadLine();
			Console.WriteLine("Digite la eps del paciente 1:");
			eps = Console.ReadLine();
			Console.WriteLine("Digite el genero del paciente 1 (m ó f)");
			bool correcto = char.TryParse(Console.ReadLine(), out genero);

			Console.WriteLine("Digite la cedula del paciente 1:");
			cedula = long.Parse(Console.ReadLine());

			Console.WriteLine("Digite la edad del paciente 1:");
			edad = int.Parse(Console.ReadLine());

			Paciente paciente1 = new Paciente(nombre, apellido, genero, edad, cedula, tiposSan, eps);

			Console.WriteLine("\nEl paciente 1 registrado con el nombre: " + paciente1.getNombre() + " " + paciente1.Apellido + "\nGenero: " + paciente1.Genero + "\nEdad: " + paciente1.Edad + "\nCedula: " + paciente1.Cedula + "\nTipo de sangre: " + paciente1.TipoSangre + "\nEps: " + paciente1.Eps + "" + "\nCodigo: " + paciente1.getCodigoPasiente());
			if (paciente1.calculoHombreMayor() == true)
			{
				Console.WriteLine("El paciente registrado es un hombre mayor de edad");
			}


			//-----------------
			Paciente paciente2;

			Console.WriteLine("\nDigite el nombre del paciente 2: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese los apellidos del paciente 2: ");
			apellido = Console.ReadLine();
			Console.WriteLine("Digite el tipo de sangre del paciente 2 : ");
			tiposSan = Console.ReadLine();
			Console.WriteLine("Digite la eps del paciente 2:");
			eps = Console.ReadLine();
			Console.WriteLine("Digite el genero del paciente 2 (m ó f)");
			bool correcto2 = char.TryParse(Console.ReadLine(), out genero);

			Console.WriteLine("Digite la cedula del paciente 2:");
			cedula = long.Parse(Console.ReadLine());

			Console.WriteLine("Digite la edad del paciente 2:");
			edad = int.Parse(Console.ReadLine());

			paciente2 = new Paciente(nombre, apellido, genero, edad, cedula);
			paciente2.TipoSangre = tiposSan;
			paciente2.Eps = eps;

			Console.WriteLine("\nEl paciente 2 registrado con el nombre: " + paciente2.getNombre() + " " + paciente2.Apellido + "\nGenero: " + paciente2.Genero + "\nEdad: " + paciente2.Edad + "\nCedula: " + paciente2.Cedula + "\nTipo de sangre: " + paciente2.TipoSangre + "\nEps: " + paciente2.Eps + "" + "\nCodigo: " + paciente2.getCodigoPasiente());
			if (paciente2.calculoHombreMayor() == true)
			{
				Console.WriteLine("El paciente registrado es un hombre mayor de edad");
			}

			//-----------------
			Paciente paciente3 = new Paciente();

			Console.WriteLine("\nDigite el nombre del paciente 3: ");
			paciente3.setNombre(Console.ReadLine());
			Console.WriteLine("Ingrese los apellidos del paciente 3: ");
			paciente3.Apellido = Console.ReadLine();
			Console.WriteLine("Digite el tipo de sangre del paciente 3 : ");
			paciente3.TipoSangre = Console.ReadLine();
			Console.WriteLine("Digite la eps del paciente 3:");
			paciente3.Eps = Console.ReadLine();
			Console.WriteLine("Digite el genero del paciente 3 (m ó f)");
			bool correcto3 = char.TryParse(Console.ReadLine(), out genero);
			paciente3.Genero = genero;

			Console.WriteLine("Digite la cedula del paciente 3:");
			paciente3.Cedula = long.Parse(Console.ReadLine());

			Console.WriteLine("Digite la edad del paciente 3:");
			paciente3.Edad = int.Parse(Console.ReadLine());

			Console.WriteLine("\nEl paciente 3 registrado con el nombre: " + paciente3.getNombre() + " " + paciente3.Apellido + "\nGenero: " + paciente3.Genero + "\nEdad: " + paciente3.Edad + "\nCedula: " + paciente3.Cedula + "\nTipo de sangre: " + paciente3.TipoSangre + "\nEps: " + paciente3.Eps + "" + "\nCodigo: " + paciente3.getCodigoPasiente());
			if (paciente3.calculoHombreMayor() == true)
			{
				Console.WriteLine("El paciente registrado es un hombre mayor de edad");
			}

		}
	}
}
