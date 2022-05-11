using System;

public class Program
{
	public static void Main()
	/*7. Leer 2 números; si son iguales que los multiplique, si el primero es mayor que el segundo que los reste y si no
que los sume.*/
	{
		int N1, N2, M, R, S;
		Console.WriteLine("digite un numero 1");
		N1 = int.Parse(Console.ReadLine());
		Console.WriteLine("digite un numero 2");
		N2 = int.Parse(Console.ReadLine());
		if (N1 == N2)
		{
			M = N1 * N2;
			Console.WriteLine("si los nuemeros son iguales se multiplican " + M);
		}
		else if (N1 > N2)
		{
			R = N1 - N2;
			Console.WriteLine(" si n1 > n2 se restan " + R);
		}
		else
		{
			S = N2 + N1;
			Console.WriteLine(" si n2 > n1 los nuemeros se suman " + S);
		}
	}
}