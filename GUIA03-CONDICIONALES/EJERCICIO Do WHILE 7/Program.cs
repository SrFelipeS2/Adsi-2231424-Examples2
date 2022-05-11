using System;

namespace EJERCICIO_Do_WHILE_7
{
    class Program
    {
        /*7. Hacer un programa que 
         * lea caracteres desde teclado hasta que lea 10 veces la letra 'a'. Por cada
carácter leído que no sea una 'a' debe mostrar un mensaje indicándolo. Cuando 
        lea las 10 letras 'a'
el programa terminará.*/
        static void Main(string[] args) 
        {
            string caracter = "a", cadena, minuscula;
            int lasvecesdea=0;
            do
            {
                Console.WriteLine("ingrese un caracter");
                cadena = Console.ReadLine();
                minuscula = cadena.ToLower();
                bool respuesta = caracter/*=a*/.Equals(minuscula);
                if (respuesta)
                {
                    lasvecesdea++;
                }
                else
                {
                    Console.WriteLine("el caracter ingresado es: " + minuscula);
                }
            } while (lasvecesdea != 10);

        }
    }
}
