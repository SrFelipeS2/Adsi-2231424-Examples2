using System;

namespace EJERCICIO_Do_WHILE_4
{
    class Program
    {
        /*4. Un censador recopila ciertos datos aplicando encuestas para el último Censo Nacional de Población
    y Vivienda. Desea obtener de todas las personas que alcance a encuestar en un día, que porcentaje
    tiene estudios de primaria, secundaria, carrera técnica, estudios profesionales y estudios de
    posgrado.
    El programa debe preguntar si se desea continuar ingresando datos.*/
        static void Main(string[] args)
        {
            {

                int estudios, primaria = 0, secundaria = 0, carreratecnica = 0,estudiosprofesionales=0,posgrados=0, totalpersonas, finalizar;
                double promedioprimaria, promediosecundaria, promediocarreratecnica, promedioestprofesional, promedioposgrados;

                do
                {
                    Console.WriteLine("que nivel de  estudios tiene? 1 para estudios de primaria, " +
                        "2 para estudios de secundaria, 3 para estudios tecnicos, " +
                        "4 para estudios profesionales y 5 para estudios superiores o posgrados ");
                    _ = int.TryParse(Console.ReadLine(), out estudios);
                    if (estudios == 1)
                    {
                        primaria++;
                    }
                    else if (estudios == 2)
                    {
                        secundaria++;
                    }
                    else if (estudios == 3)
                    {
                        carreratecnica++;
                    }
                    else if (estudios == 4)
                    {
                        estudiosprofesionales++;
                    }
                    else if (estudios == 5)
                    {
                        posgrados++;
                    }
                    Console.WriteLine("para terminar la encuesta use el numero 6, de lo contrario presione 'enter'");
                    _ = int.TryParse(Console.ReadLine(), out finalizar);

                } while (finalizar != 6);
                totalpersonas = primaria + secundaria + carreratecnica + estudiosprofesionales + posgrados;
                promedioprimaria = (primaria * 100) / totalpersonas;
                promediosecundaria = (secundaria * 100) / totalpersonas;
                promediocarreratecnica = (carreratecnica * 100) / totalpersonas;
                promedioestprofesional = (estudiosprofesionales * 100) / totalpersonas;
                promedioposgrados = (posgrados * 100) / totalpersonas;
                Console.WriteLine("el total de personas encuestadas es de:" + totalpersonas + " ,el promedio de las personas que tienen estudios basicos en primaria es "+ promedioprimaria 
                    + "% el promedio de las personas que tienen estudios en la secundaria es " + promediosecundaria +
                    "% el promedio de las personas que tienen estudios tecnicos es: " + promediocarreratecnica +
                    "% el promedio de las personas que tienen estudios profesionales es: " + promedioestprofesional + 
                    "% el promedio de las personas que tienen estudios superiores o posgrados es: " + promedioposgrados +"%");
            }
        }
    }
}
