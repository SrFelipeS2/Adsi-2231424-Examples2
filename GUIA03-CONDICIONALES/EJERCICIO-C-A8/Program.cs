using System;

public class Program
{
	public static void Main()
	/*8. El jefe del departamento de construcción de la constructora Pagasa, desea que se le desarrolle un programa
en C++ para sus empleados, el cual calcule el sueldo de un empleado, de tal manera que el sueldo se calculará
de la siguiente manera: si el número de horas trabajadas es mayor a 40, el excedente de 40 hrs. se paga al
doble de la cuota por hora, en caso de no ser mayor a 40 hrs. se paga la cuota normal por hora, si las horas
exceden a 50 hrs. el excedente de 50 hrs. se paga al triple de la cuota por hora. Se pedirá el nombre del
empleado, el número de horas trabajadas y la cuota por hora. mostrar en pantalla el nombre del empleado, el
número de horas trabajadas y su sueldo.*/
	{
		String nombre;
		double H, VH, sueldo, HE;
		Console.WriteLine("nombre de empleado");
		nombre = (Console.ReadLine());
		Console.WriteLine(" numero de horas laboradas : ");
		H = double.Parse(Console.ReadLine());
		Console.WriteLine(" valor por cada hora :");
		VH = double.Parse(Console.ReadLine());
		if (H >= 0 && H <= 40)
		{
			sueldo = H * VH;
			Console.WriteLine("el nombre del empleado es : " + nombre);
			Console.WriteLine("las horas trabajadas son: " + H);
			Console.WriteLine("su sueldo es de: $" + sueldo);
		}
		else if (H > 40 && H <= 50)
		{
			HE = (H - 40) * (VH * 2);
			sueldo = (40 * VH) + HE;
			Console.WriteLine("el nombre del empleado es : " + nombre);
			Console.WriteLine("las horas trabajadas son: " + H);
			Console.WriteLine("su sueldo es de: $" + sueldo);
		}
		else if (H > 50)
		{
			HE = (H - 50) * (VH * 3);
			sueldo = (50 * VH) + HE;
			Console.WriteLine("el nombre del empleado es : " + nombre);
			Console.WriteLine("las horas trabajadas son: " + H);
			Console.WriteLine("su sueldo es de: $" + sueldo);
		}
	}
}