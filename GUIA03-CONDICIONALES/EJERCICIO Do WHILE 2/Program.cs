using System;

namespace EJERCICIO_Do_WHILE_2
{
    class Program
    {
        /*2. Un alumno de la clase de lógica matemática desea desarrollar un algoritmo y diagrama de flujo en el
       cual introduzca un número entero positivo e invierta los dígitos del número. Mostrar el número
       invertido.*/
        static void Main(string[] args)
        {
            int continuar, numeroinverso, numero, residuo;
            do
            {
                Console.WriteLine("ingrese un numero entero de dos cifras");
                _ = int.TryParse(Console.ReadLine(), out numero);
                residuo = numero % 10;
                numeroinverso = numero / 10;
                Console.WriteLine("el numero invertido es: " + residuo + numeroinverso);
                Console.WriteLine("desea ingresar otro numero? 1 para si, 0 para no");
                _ = int.TryParse(Console.ReadLine(), out continuar);

            } while (continuar == 1);

        }
    }

}