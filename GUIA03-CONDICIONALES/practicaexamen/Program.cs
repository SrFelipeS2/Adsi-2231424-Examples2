using System;

namespace practicaexamen
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Clase jugador atributos salario, impuestos, gastos, declarar 
             * Ingresar n jugadores.
             * Ingresar n equipos.    */
            string nombreJ, nombreE, pais;
            int numCamiseta, cantEquipos, cantJugadores;
            double salario, gastos, impuestos;
            bool verificar;
            Equipo[] vectorEquipos;

            do
            {
                Console.Write("INGRESE EL NUMERO DE EQUIPOS QUE VA A INGRESAR");
                verificar = int.TryParse(Console.ReadLine(), out cantEquipos);
            } while (cantEquipos<=0);
            vectorEquipos = new Equipo[cantEquipos];
  
            for(int i=0; i<vectorEquipos.Length; i++)
            {
                Console.Write("INGRESE EL NOMBRE DEL EQUIPO " + (i + 1)+": ");
                nombreE = Console.ReadLine();

                Console.Write("INGRESE EL PAIS DONDE PERTENECE EL EQUIPO ");
                pais = Console.ReadLine();

                Equipo club = new Equipo(nombreE,pais);

                do
                {
                    Console.Write("INGRESE EL NUMERO DE JUGADORES QUE VA A INGRESAR");
                    verificar = int.TryParse(Console.ReadLine(), out cantJugadores);
                } while (cantJugadores <= 0);
                for (int a=0;a<cantJugadores;a++)
                {
                    Console.Write("\nINGRESE NOMBRE DEL JUGADOR " + (a + 1) + ": ");
                    nombreJ = Console.ReadLine();
                       do
                    {
                        Console.Write("INGRESE EL NUMERO DE CAMISETA DEL JUGADOR");
                        verificar = int.TryParse(Console.ReadLine(), out numCamiseta);
                    } while (numCamiseta <= 0);
                    do
                    {
                        Console.Write("INGRESE SU SALARIO");
                        verificar = double.TryParse(Console.ReadLine(), out salario);
                    } while (salario <= 0);
                    do
                    {
                        Console.Write("INGRESE SUS IMPUESTOS");
                        verificar = double.TryParse(Console.ReadLine(), out impuestos);
                    } while (impuestos <= 0);
                    do
                    {
                        Console.Write("INGRESE SUS GASTOS");
                        verificar = double.TryParse(Console.ReadLine(), out gastos);
                    } while (gastos < 0 || verificar == false);

                    Jugador deportista=new Jugador();
                    deportista.setNombre(nombreJ);
                    deportista.NumCamiseta = numCamiseta;
                    deportista.Salario = salario;
                    deportista.Gastos = gastos;
                    deportista.Impuestos = impuestos;
                    deportista.calcularDineroRestante();
                    club.agregarjugador(deportista);

                }//cierre del for de los jugadores
                vectorEquipos[i] = club;

            }// cierre de ciclo de los n equipos

            for(int i=0; i < vectorEquipos.Length; i++)
            {
                Console.WriteLine("*******************************************************");
                Console.WriteLine("EL EQUIPO " + vectorEquipos[i].NombreEquipo + " DEL PAIS " + vectorEquipos[i].Pais + " TIENE LOS SIGUIENTES JUGADORES: ");//de esta manera se accede a la informacion del vector 
                for(int k=0; k < vectorEquipos[i].getListaJuagadores().Count; k++) 
                {
                    Console.WriteLine("\n nombre: "+vectorEquipos[i].getListaJuagadores()[k].getNnombre() + "\nEl numero de la camiseta dle jugador es: "+ vectorEquipos[i].getListaJuagadores()[k].NumCamiseta+ "\nEl salario del jugador es: "+vectorEquipos[i].getListaJuagadores()[k].Salario+ "\nLos gastos del jugador son: "+vectorEquipos[i].getListaJuagadores()[k].Gastos+"\nLos impuestos del jugador son: "+vectorEquipos[i].getListaJuagadores()[k].Impuestos+"\n el dinero restante del jugador es: "+vectorEquipos[i].getListaJuagadores()[k].DineroRestante);
                }
            }

        }

    }
}

