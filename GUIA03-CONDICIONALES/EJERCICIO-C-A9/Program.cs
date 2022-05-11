using System;

public class Program
{
	public static void Main()
	{
		/*9. El fondo de administración de pensiones requiere clasificar a las personas que se jubilaran en el año 2009.
Existen tres tipos de jubilaciones: por edad, por antigüedad joven y por antigüedad adulta. Las personas
adscritas a la jubilación por edad deben tener 60 años o mas y una antigüedad en su empleo de menos de 25
años.
Las personas adscritas a la jubilación por antigüedad joven deben tener menos de 60 años y una antigüedad
en su empleo de 25 años o más.
Las personas adscritas a la jubilación por antigüedad adulta deben tener 60 años o mas y una antigüedad en su
empleo de 25 años o mas.
Determinar en que tipo de jubilación, quedara adscrita una persona.*/
		double edad, ATrabajo, AAdulta, AJuvenil;
		Console.WriteLine("cual es su edad");
		edad = double.Parse(Console.ReadLine());
		Console.WriteLine("cuantos años ah trabajados");
		ATrabajo = double.Parse(Console.ReadLine());
		if (edad < 60 && ATrabajo >= 25)
		{
			AJuvenil = ATrabajo + edad;
			Console.WriteLine("usted esta adscrito a la jubilación por antigüedad joven ");
		}
		else if (edad >= 60 && ATrabajo >= 25)
		{
			AAdulta = ATrabajo + edad;
			Console.WriteLine("usted esta adscrito a la jubilación por antigüedad adulta ");
		}
		else if (edad >= 60 && ATrabajo <25)
		{
			AAdulta = ATrabajo + edad;
			Console.WriteLine("usted esta adscrito a la jubilación  por edad ");
		}

	}
}