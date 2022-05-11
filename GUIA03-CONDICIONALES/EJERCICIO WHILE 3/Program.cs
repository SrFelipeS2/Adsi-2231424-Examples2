using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        /*3. Determinar cuantos hombres y cuantas mujeres se encuentran en un grupo de n personas,
suponiendo que los datos son extraídos alumno por alumno.*/
        {
            int cantidadpersonas, n=0;
            double hom=1, canthombres=0,cantmujer=0;
            Console.WriteLine("Ingrese la cantidad de personas");
            _ = int.TryParse(Console.ReadLine(), out cantidadpersonas);
            while (n < cantidadpersonas)

            {
                Console.WriteLine("la persna " + (n + 1) + " es hombre?, 1 para si 0 para no");
                    _ = double.TryParse(Console.ReadLine(), out hom);
                if(hom == 1) 
                {
                    canthombres++;
                }
                else{
                    cantmujer++;
                }
                n++;
            }
            Console.WriteLine("en el grupo de personas hay " + canthombres + " hombres y " + cantmujer + " mujeres");
            
        }
    }
}
