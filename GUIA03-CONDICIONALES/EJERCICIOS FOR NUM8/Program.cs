using System;

namespace EJERCICIOS_FOR_NUM8_1
{
    class Program
    {
        /*8. Un alumno de la clase de lógica matemática desea desarrollar un programa 
         * que calcule el factorial
         de un número N, el cual le dará al usuario, el factorial de un número N, 
        definido matemáticamente
        como N! se obtiene como la multiplicación de todos los números que están desde el 1 
        hasta el N = 1
         * 2 * 3 * ..... (N-2) * (N-1) * N, como se muestra en la figura, por definición el 
        * factorial de 0 es 1.*/
        static void Main(string[] args) {
            int numero, factorial = 1;
            Console.WriteLine("buen dia digit un numero Natural para calcular el factorial" );
            _ = int.TryParse(Console.ReadLine(), out numero);
            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("el factorial de " + numero + " es igual a: " + factorial);
        }
    }
}
