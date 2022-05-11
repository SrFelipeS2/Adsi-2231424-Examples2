using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO1POOGUIA2
{
    public class programacionestructurada
    {
        public static void Main(string[] args)
        {
            /*3. Almacenar 15 números en un vector, imprimir cuantos son ceros, cuántos son negativos, cuantos
positivos. Imprimir además la suma de los negativos, la suma de los ceros y la suma de los positivos.*/
            bool NEW;
            int TAMAÑOVECTOR;
            double[] valor;
            Console.WriteLine("POR FAVOR INGRESE LA CANTIDAD DE NUMEROS QUE VA A INGRESAR");
            NEW = int.TryParse(Console.ReadLine(), out TAMAÑOVECTOR);
            valor = new double[TAMAÑOVECTOR];
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("POR FAVOR INGRESE EL VALOR : " + (i + 1));
                valor[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("************************************");
            }
            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] > 0)
                {
                    Console.WriteLine("LOS NUMEROS MAYORES A CERO SON: " + valor[i]);
                }
                else
                {
                    Console.WriteLine("EN ESTE ESPACIO NO SE ASIGNARON NUMEROS MAYORES A CERO");
                }
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }

    }
}
