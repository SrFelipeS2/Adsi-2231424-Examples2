using System;

namespace EJERCICIO_C_M4
{
    class Program

    
    {
        static void Main(string[] args)
        {
            double V, res, opcion;
            Console.WriteLine("Buen dia cual es el valor con que realizara la operacion?");
            V = int.Parse(Console.ReadLine());
            opcion = V % 4;
            switch (opcion)
            {
                case 0:
                    res = Math.Pow(V,2);
                    break;
                case 1:
                    res = V/6;
                    break;
                case 2:
                    res = Math.Sqrt(V);
                    break;
                case 3:
                    res = Math.Pow(V,3)+(5);
                    break;

                default:
                    res = 0;

                    break;

            }

            Console.WriteLine("Buen dia el resultado es:" + res);

        }
    }
}