using System;

namespace EJERCICIO_Do_WHILE_3
{
    class Program
    {
        /*3. En la Cámara de Diputados se levanta una encuesta con todos los integrantes con el fin de 
         * determinar
que porcentaje de los n diputados esta a favor del Tratado de Libre Comercio, que porcentaje esta en
contra y que porcentaje se abstiene de opinar.
El programa debe preguntar si se desea continuar ingresando datos.*/
        static void Main(string[] args)
        {
            {
                
                int tratado, deacuerdo=0, desacuerdo=0, noresponde=0, totaldiputados, finalizar;
                double promediosi, promediono, promedionoresponde;
             
                do
                {
                    Console.WriteLine("usted esta deacuerdo con el tratado 1 para si, " +
                        "0 para no, y 2 si se abstiene de responder");
                    _ = int.TryParse(Console.ReadLine(), out tratado);
                    if (tratado == 1)
                    {
                        deacuerdo ++;
                    }
                    else if ( tratado == 0)
                    {
                        desacuerdo ++;
                    }
                    else if(tratado == 2)
                    {
                        noresponde ++;
                    }
                    Console.WriteLine("desea ingresar mas datos? use 4 para continuar");
                    _ = int.TryParse(Console.ReadLine(), out finalizar);
      
                } while (finalizar != 3);
                totaldiputados = deacuerdo + desacuerdo + noresponde;
                promediosi = (deacuerdo *100)/ totaldiputados;
                promediono = (desacuerdo *100)/ totaldiputados;
                promedionoresponde = (noresponde *100)/ totaldiputados;
                Console.WriteLine("el promedio de los diputados que votaron por el no es igual a " + promediono + " el promedio para los diputados que votaron por el si es igual a: " + promediosi + " el promedio de los diputados  que se abstienen de votar es igual a: " + promedionoresponde);
            }
        }
    }
}
