using System;

namespace EJERCICIOARRAY7
{
    class Program
    {
/*7. Una agencia de seguros desea obtener un reporte al final del día de sus n empleados para determinar
cuál fue el empleado que obtuvo el mayor sueldo en base a sus ventas y comisiones, se registrará el
nombre del empleado la edad y el sueldo que obtuvo al final del día. Desarrollar un programa que
pida al usuario el nombre de los n empleados, su edad y el sueldo para generar un reporte que lo
muestre en pantalla de la siguiente manera: el nombre del empleado, edad, sueldo, el empleado con
mayor sueldo, el sueldo del empleado que gana más y su edad.
Debe declarar un arreglo de enteros para la edad.
Debe declarar un arreglo de reales para el sueldo.
Debe declarar un arreglo de cadena para el nombre*/
        static void Main(string[] args)
        {
            int POSVECT,POSICION=0;
            double SUELDOMAYOR=0;

            Console.WriteLine("POR FAVOR INGRESE LA CANTIDAD DE EMPLEADOS: ");
            _ = int.TryParse(Console.ReadLine(), out POSVECT);
            int[] vectorEDAD;
            vectorEDAD = new int[POSVECT];
            double[] vectorSUELDO;
            vectorSUELDO = new double[POSVECT];
            string[] vectorNOMBRE;
            vectorNOMBRE = new string[POSVECT];
            for (int i = 0; i < vectorEDAD.Length; i++)
            {
                Console.WriteLine("POR FAVOR INGRESE LA EDAD DEL EMPLEADO # " + i );
                vectorEDAD[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("POR FAVOR INGRESE EL SUELDO DEL EMPLEADO # " + i );
                vectorSUELDO[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("POR FAVOR INGRESE EL NOMBRE DEL EMPLEADO # " + i );
                vectorNOMBRE[i] = (Console.ReadLine());
                Console.WriteLine("EL  NOMBRE DEL EMPLEADO ES: " + vectorNOMBRE[i]);
                Console.WriteLine("LA EDAD DEL EMPLEADO ES: " + vectorEDAD[i]);
                Console.WriteLine("EL SUELDO DEL EMPLEADO ES: " + vectorSUELDO[i]);
                Console.WriteLine("************************************");
                if (vectorSUELDO[i] > SUELDOMAYOR)
                {
                    SUELDOMAYOR=vectorSUELDO[i];
                    POSICION = i;
                }
                Console.WriteLine("************************************");
            }
            Console.WriteLine("EL EMPLEADO CON MAYOR SUELDO ES: " + vectorNOMBRE[POSICION]);
            Console.WriteLine("LA EDAD DEL EMPLEADO CON MAYOR SUELDO ES: " + vectorEDAD[POSICION]);
            Console.WriteLine("LA PAGA DEL EMPLEADO CON MAYOR SUELDO ES: " + vectorSUELDO[POSICION]);

        }
    }
}
