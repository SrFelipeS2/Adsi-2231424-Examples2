using System;
           
namespace EJERCICIO_Do_WHILE_8
{
    class Program
    {
        /*8. Hacer un programa que lea caracteres desde teclado y vaya contando las vocales 
         * que aparecen. El
programa terminará cuando lea el carácter # y entonces mostrará un mensaje indicando cuántas
vocales ha leído (cuántas de cada una de ellas).*/
        static void Main(string[] args)
        {
            string[] caracter = { "a", "e", "i", "o","u", };
            string cadena, minuscula;
            int lasvecesdea = 0, lasvecesdee=0,lasvecesdei=0,lasvecesdeo=0,lasvecesdeu=0;
            do
            {
                Console.WriteLine("ingrese un caracter");
                cadena = Console.ReadLine();
                minuscula = cadena.ToLower();
                bool respuesta = caracter[0].Equals(minuscula);
                bool respuesta1 = caracter[1].Equals(minuscula);
                bool respuesta2 = caracter[2].Equals(minuscula);
                bool respuesta3 = caracter[3].Equals(minuscula);
                bool respuesta4 = caracter[4].Equals(minuscula);

                if (respuesta)
                {
                    lasvecesdea++;
                }
                else if (respuesta1)
                {
                    lasvecesdee++;
                }
                else if (respuesta2)
                {
                    lasvecesdei++;
                }
                else if (respuesta3)
                {
                    lasvecesdeo++;
                }
                else if (respuesta4)
                {
                    lasvecesdeu++;
                }

            } while (minuscula != "#");
            Console.WriteLine("ah ingresado #" + lasvecesdea + " veces la vocal a," + " ah ingresado #" + lasvecesdee + " veces la vocal e," + " ah ingresado #" + lasvecesdei + " veces la vocal i," + " ah ingresado #" + lasvecesdeo
                    + "veces la vocal o," + " ah ingresado #" + lasvecesdeu + "veces la vocal u");
        }
    }
}
