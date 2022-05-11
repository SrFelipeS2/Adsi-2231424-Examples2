using System;

namespace EJERCICIO_Do_WHILE_5
{
    class Program
    {/*
        5. Calcular la suma siguiente:
100 + 98 + 96 + 94 + . . . + 0 en este orden*/
        static void Main(string[] args)
        {
            int X = 100, suma = 0;
                do
            {
                suma = suma + X;
                X = X - 2;
            } while (X != 0);
            Console.WriteLine("Calcular la suma siguiente: 100 + 98 + 96 + 94 + . . . +" +
                " 0 en este orden, la suma de los numeros es " + suma);
        }
    }
}
