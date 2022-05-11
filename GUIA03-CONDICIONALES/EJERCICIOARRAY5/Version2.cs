using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOARRAY5
{
    class Version2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VERSION2;");
            /*5. Diseñe un algoritmo que lea un número cualquiera y lo busque en el vector X, el cual tiene
almacenados 12 elementos. Escribir la posición donde se encuentra almacenado el número en el
vector o el mensaje “NO” si no lo encuentra.*/
            int POSVECT; 
            bool BUSQUEDA=false;
            Console.WriteLine("POR FAVOR INGRESE LA CANTIDAD DE POSCICIONES EN EL VECTOR : ");
            _ = int.TryParse(Console.ReadLine(), out POSVECT);
            double[] valor ;
            valor = new double[POSVECT];
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("POR FAVOR INGRESE EL NUMERO QUE VA A ASIGNAR EN LA POSICION # : " + i );
                valor[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("POR FAVOR INGRESE EL NUMERO QUE SE VA A BUSCAR EN EL VECTOR");
            _ = double.TryParse(Console.ReadLine(), out double numero);
            
            for (int i = 0; i < valor.Length; i++)
            {
                //Console.WriteLine("POSICION" + i);
                 if (valor[i] == numero)
                 {
                    Console.WriteLine("LA POSICION EN LA QUE SE ENCUENTRA EL VALOR QUE INGRESO ES ; ");
                    Console.WriteLine(i);
                    BUSQUEDA = true;
                    break;
                 }
                
            }
            if (BUSQUEDA == false)
            {
                Console.WriteLine("NO SE ENCONTRARON RESULTADOS EN LA BUSQUEDA : ");
            }
           
        }
    }
}
