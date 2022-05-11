using System;

namespace EJERCICIOS_FOR_NUM6
{
    class Program
    {
        static void Main(string[] args)
        /*Una persona debe realizar un muestreo con 50 personas para determinar el 
         * promedio de peso de los
           niños, jóvenes, adultos y adultos mayores que existen en su zona 
           habitacional. Se determinan las
           categorías con base en la sig, tabla
           CATEGORIA EDAD
           Niños 0 – 12
           Jóvenes 13 - 29
           Adultos 30 - 59
           Adultos Mayores 60 en adelante
        Se debe solicitar la edad y el peso de cada persona y calcular y mostrar el 
        promedio por categoría.
        */
        {
            double peso, edad, prom1, prom2, prom3, prom4, suma1 = 0, suma2 = 0, suma3 = 0,
                suma4 = 0, cat1 = 0, cat2 = 0, cat3 = 0, cat4 = 0;
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("buen dia ingrese su edad");
                _ = double.TryParse(Console.ReadLine(), out edad);
                Console.WriteLine("buen dia ingrese su peso");
                _ = double.TryParse(Console.ReadLine(), out peso);
                if(edad >=0 && edad <= 12)
                {
                    cat1++;
                    suma1 += peso;
                }
                else if( edad <= 29)
                {
                    cat2++;
                    suma2 += peso;
                    
                }
                else if ( edad <= 59)
                {
                    cat3++;
                    suma3 += peso;  
                }
                else {
                    cat4++;
                    suma4 += peso;  
                }
            }
            prom1 = suma1 / cat1;
            prom2 = suma2 / cat2;
            prom3 = suma3 / cat3;
            prom4 = suma4 / cat4;
            if(cat1!=0)
            { Console.WriteLine("el promedio del peso para la categoria de niños es:" + prom1);}
            else { Console.WriteLine("no se ingresaron datos para la categoria de niños" ); }
            if (cat2 != 0)
            { Console.WriteLine("el promedio del peso para la categoria de jovenes es:" + prom2); }
            else { Console.WriteLine("no se ingresaron datos para la categoria de jovenes"); }
            if (cat3 != 0)
            { Console.WriteLine("el promedio del peso para la categoria de adultos es:" + prom3); }
            else { Console.WriteLine("no se ingresaron datos para la categoria de adultos"); }
            if (cat4 != 0)
            { Console.WriteLine("el promedio del peso para la categoria de adultos mayores es:" + prom4); }
            else { Console.WriteLine("no se ingresaron datos para la categoria de adultos mayores"); }
            
        }
    }
}
