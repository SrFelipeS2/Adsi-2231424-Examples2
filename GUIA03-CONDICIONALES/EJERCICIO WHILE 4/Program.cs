using System;

namespace EJERCICIO_WHILE_4
{
    class Program
    {
        /*4. El Depto. de Seguridad Publica y Transito del D.F. desea saber,
         de los n autos que entran a la ciudad
        de México, cuantos entran con calcomanía de cada color. 
        Conociendo el último dígito de la placa de
        cada automóvil se puede determinar el color de la calcomanía utilizando la sig. relación:
        DÍGITO COLOR
        1 o 2 amarilla
        3 o 4 rosada
        5 o 6 roja
        7 o 8 verde
        9 o 0 azul*/
        static void Main(string[] args)
        {
            int cantidadautos, n = 0;
            double color = 1, amarilla = 0, rosada = 0, roja=0,verde=0,azul=0;
            Console.WriteLine("Ingrese la cantidad de automoviles que ingresaron al DF");
            _ = int.TryParse(Console.ReadLine(), out cantidadautos);
            while (n < cantidadautos)

            {
                Console.WriteLine("el automovil " + (n + 1) + " en que numero terminaba la placa?");
                _ = double.TryParse(Console.ReadLine(), out color);
                if (color == 1 || color == 2)
                {
                    amarilla++;
                }
                else if (color == 3 || color == 4)
                {
                    rosada++;
                }
                else if (color == 5 || color == 6)
                {
                    roja++;
                }
                else if (color == 7 || color == 8)
                {
                    verde++;
                }
                else
                {
                    azul++;
                }
                n++;
            }  
                Console.WriteLine("en el DF ingresaron " + cantidadautos + " automoviles, de los cuales " + amarilla
                    + " tienen placa amarilla, " + rosada + " tienen placa rosada, " + roja + " tienen placa roja, "
                    + verde + " tienen placa verde, " + azul + " tienen placa azul");
            
           
        }
    }
}
