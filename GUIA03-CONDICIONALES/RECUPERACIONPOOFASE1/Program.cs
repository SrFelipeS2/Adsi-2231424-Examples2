using System;
using System.Collections.Generic;

namespace RECUPERACIONPOOFASE1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreEntrenador, email;
            int preferenciasenaon,opciongeneral, cambiosenamonentrenador=0,cambiosenamon,cambioestadistica;
            bool validacion, seguir=true;
            DateTime fecahdenacimiento;
            Console.WriteLine("Hello World!");
            Entreador entreador;
            List<Senamon> TodosLosSenamones = new List<Senamon>();
            List<Entreador> TodosLosEntrenadores = new List<Entreador>();

            Senamon senamon1 = new Senamon("Electrimon", "electrico", 10.5, 110, 70,1, "senamon 001");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Cablemon", "electrico", 5, 95, 45,1, "senamon 002");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Arbolmon", "hierva", 20, 100, 45,1, "senamon 003");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Semillamon", "hierva", 3, 80, 35,1, "senamon 004");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Olamon", "Agua", 15, 60, 77,2, "senamon 005");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Cascadamon", "Agua", 10, 100, 60,1, "senamon 006");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Candelamon", "fuego", 5, 125, 65,1, "senamon 007");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Fuegomon", "fuego", 8, 96, 75,2, "senamon 008");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Airemon", "Aire", 2, 127, 35,1, "senamon 009");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("huracanmon", "aire", 40, 100, 95,3, "senamon 010");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Trollywick", "electrico", 48, 95, 50,1, "senamon 011");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Crockisticks", "electrico", 20, 100, 25,1, "senamon 012");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Flowerair", "hierva", 30, 126, 85,3, "senamon 013");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("tairrain", "hierva", 40, 96, 62,1, "senamon 014");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Olaffitty", "agua", 25, 133, 43,1, "senamon 015");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Waterrick", "agua", 65, 98, 69,1, "senamon 016");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Faircow", "fuego", 55, 100, 45,1, "senamon 017");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Lavasick", "fuego", 23, 128, 30,1, "senamon 018");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Snusnumon", "aire", 43, 100, 59,1, "senamon 019");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new Senamon("Frogmom", "aire", 25, 100, 90,3, "senamon 020");
            TodosLosSenamones.Add(senamon1);

            //show all senamones 
            Console.WriteLine("********************************************************************************************");
            for (int i = 0; i < TodosLosSenamones.Count; i++)
            {
                Console.WriteLine($"nombre: {TodosLosSenamones[i].nombresenamon} tipo: {TodosLosSenamones[i].tipo} peso: {TodosLosSenamones[i].peso} Kg - salud: {TodosLosSenamones[i].puntosdesalud} ataque: {TodosLosSenamones[i].puntosdeataque} descripcion: {TodosLosSenamones[i].descripcion}");
            }
            Console.WriteLine("********************************************************************************************");
            //ingresar entrenador y seleccion de senamones
            for (int i = 0; i < 2; i++)
            {
                Console.Write("ingrese el nombre del entrenador:");
                nombreEntrenador = Console.ReadLine();
                Console.Write("ingrese el email:");
                email = Console.ReadLine();
                Console.WriteLine("ingrese la fecha de nacimiento del entrenador: ");
                _ = DateTime.TryParse(Console.ReadLine(), out fecahdenacimiento);
                entreador = new Entreador(nombreEntrenador, email, fecahdenacimiento);
                Console.WriteLine("********************************************************************************************");
                Console.WriteLine("DE LA SIGUIENTE LISTA ELIJA 5 SENAMONES EN BASE  A SU NUMERO ANTECESOR ");
                for (int a = 0; a < TodosLosSenamones.Count; a++) 
                {
                    Console.WriteLine($" {a} nombre: {TodosLosSenamones[a].nombresenamon} salud: {TodosLosSenamones[a].puntosdesalud} ataque: {TodosLosSenamones[a].puntosdeataque}");
                }
                Console.WriteLine("********************************************************************************************");
                for (int k = 0; k < 5; k++)
                {
                    while(true) {
                     validacion = int.TryParse(Console.ReadLine(), out preferenciasenaon);
                        if (validacion == true && preferenciasenaon >= 0 && preferenciasenaon <= TodosLosSenamones.Count)
                        {
                            entreador.setsenamon(TodosLosSenamones[preferenciasenaon]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("ingreso mal, recuerde son los numeros izquierdos en la lista");
                        }
                    }
                   
                }
                TodosLosEntrenadores.Add(entreador);
                Console.WriteLine("********************************************************************************************");
            }

            for(int i = 0; i < TodosLosEntrenadores.Count; i++)
            {
                Console.WriteLine($"entreador: {TodosLosEntrenadores[i].getNombre()} correo: {TodosLosEntrenadores[i].Correo} fecha de nacimiento {TodosLosEntrenadores[i].Fechadenacimiento.ToShortDateString()}");
                Console.WriteLine("sus senamones son: "); 
                for (int b=0; b < 5; b++) 
                {
                    Console.WriteLine($" senamon {b + 1} : {TodosLosEntrenadores[i].getvectorsenamon()[b].nombresenamon}"); 
                }
                Console.WriteLine("********************************************************************************************");
            }
            Console.WriteLine("********************************************************************************************");
            while (seguir==true)
            {
                Console.WriteLine("opciones generales");
                Console.WriteLine("1 - para cambiar senamon");
                Console.WriteLine("2 - para aumentar estadisticas");
                Console.WriteLine("3 - iniciar batalla");
                Console.WriteLine("4 - finalizar");
                do
                {
                    Console.WriteLine("digite la opcion correspondiente");
                    validacion = int.TryParse(Console.ReadLine(), out opciongeneral);
                } while (validacion = false || opciongeneral < 1 || opciongeneral > 4);
                switch (opciongeneral)
                {
                    case 1:
                        Console.Write($"digite el numero del entrenador que cambiara sus senamones" + $"( 1- {TodosLosEntrenadores[0].getNombre()} 2- {TodosLosEntrenadores[1].getNombre()} 3- para cancelar )");
                        do
                        {
                            Console.WriteLine("digite la opcion correspondiente");
                            validacion = int.TryParse(Console.ReadLine(), out cambiosenamonentrenador);
                        } while (cambiosenamonentrenador != 1 && cambiosenamonentrenador != 2 && cambiosenamonentrenador != 3);
                        if (cambiosenamonentrenador == 1)
                        {
                            Console.WriteLine(" digite el numero de senamon que desea cambiar ");
                            for (int b = 0; b < 5; b++)
                            {
                                Console.WriteLine($"\n senamon {b} : {TodosLosEntrenadores[0].getvectorsenamon()[b].nombresenamon}\n");
                            }
                            do
                            {
                                validacion = int.TryParse(Console.ReadLine(), out cambiosenamon);
                            } while (validacion = false || cambiosenamon < 0 || cambiosenamon > 4);
                            TodosLosEntrenadores[0].eliminarsenamon(cambiosenamon);
                            Console.WriteLine("DE LA SIGUIENTE LISTA ELIJA 1 ");
                            for (int a = 0; a < TodosLosSenamones.Count; a++)
                            {
                                Console.WriteLine($" {a} nombre: {TodosLosSenamones[a].nombresenamon} salud: {TodosLosSenamones[a].puntosdesalud} ataque: {TodosLosSenamones[a].puntosdeataque}");
                            }
                            do
                            {
                                Console.WriteLine("DIGITE EL NUMERO CORRESPONDIENTE DEL SENAMON ");
                                validacion = int.TryParse(Console.ReadLine(), out cambiosenamon);
                            } while (validacion = false || cambiosenamon < 0 || cambiosenamon > TodosLosSenamones.Count);
                            TodosLosEntrenadores[0].setsenamon(TodosLosSenamones[cambiosenamon]);
                        }
                        else if (cambiosenamonentrenador == 2)
                        {
                            Console.WriteLine(" digite el numero de senamon que desea cambiar ");
                            for (int b = 0; b < 5; b++)
                            {
                                Console.WriteLine($"\n senamon {b} : {TodosLosEntrenadores[1].getvectorsenamon()[b].nombresenamon}\n");
                            }
                            do
                            {
                                validacion = int.TryParse(Console.ReadLine(), out cambiosenamon);
                            } while (validacion = false || cambiosenamon < 0 || cambiosenamon > 4);
                            TodosLosEntrenadores[1].eliminarsenamon(cambiosenamon);
                            Console.WriteLine("DE LA SIGUIENTE LISTA ELIJA 1 ");
                            for (int a = 0; a < TodosLosSenamones.Count; a++)
                            {
                                Console.WriteLine($" {a} nombre: {TodosLosSenamones[a].nombresenamon} salud: {TodosLosSenamones[a].puntosdesalud} ataque: {TodosLosSenamones[a].puntosdeataque}");
                            }
                            do
                            {
                                Console.WriteLine("DIGITE EL NUMERO CORRESPONDIENTE DEL SENAMON ");
                                validacion = int.TryParse(Console.ReadLine(), out cambiosenamon);
                            } while (validacion = false || cambiosenamon < 0 || cambiosenamon > TodosLosSenamones.Count);
                            TodosLosEntrenadores[1].setsenamon(TodosLosSenamones[cambiosenamon]);
                        }
                        else
                        { Console.WriteLine("OPERACION CANCELADA"); }
                        break;
                    case 2:
                        Console.Write($"digite el numero del entrenador que aumentara la estadistica de un senamon" + $"( 1- {TodosLosEntrenadores[0].getNombre()} 2- {TodosLosEntrenadores[1].getNombre()} 3- para cancelar )");
                        do
                        {
                            Console.WriteLine("digite la opcion correspondiente");
                            validacion = int.TryParse(Console.ReadLine(), out cambiosenamonentrenador);
                        } while (cambiosenamonentrenador != 1 && cambiosenamonentrenador != 2 && cambiosenamonentrenador != 3);
                        if (cambiosenamonentrenador == 1)
                        {
                            if (TodosLosEntrenadores[0].experienciaentrenador >= 200)
                            {
                                Console.WriteLine(" digite el numero de senamon que desea aumentar ");
                                for (int b = 0; b < 5; b++)
                                {
                                    Console.WriteLine($"\n senamon {b} : {TodosLosEntrenadores[0].getvectorsenamon()[b].nombresenamon}\n");
                                }
                                do
                                {
                                    Console.WriteLine("digite la opcion correspondiente");
                                    validacion = int.TryParse(Console.ReadLine(), out cambiosenamon);
                                } while (validacion = false || cambiosenamon < 0 || cambiosenamon > 4);
                                Console.WriteLine($" que estadistica va a aumentar " + $"( 1- ATAQUE  actual {TodosLosEntrenadores[0].getvectorsenamon()[cambiosenamon].puntosdeataque} 2- SALUD actual{TodosLosEntrenadores[0].getvectorsenamon()[cambiosenamon].puntosdesalud} )");
                                do
                                {
                                    Console.WriteLine("digite la opcion correspondiente");
                                    validacion = int.TryParse(Console.ReadLine(), out cambioestadistica);
                                } while ( cambioestadistica != 1 && cambioestadistica != 2);
                                if (cambioestadistica == 1)
                                {
                                    TodosLosEntrenadores[0].getvectorsenamon()[cambiosenamon].puntosdeataque = TodosLosEntrenadores[0].getvectorsenamon()[cambiosenamon].puntosdeataque + 20;
                                }
                                else
                                {
                                  TodosLosEntrenadores[0].getvectorsenamon()[cambiosenamon].puntosdeataque = TodosLosEntrenadores[0].getvectorsenamon()[cambiosenamon].puntosdesalud + 20;
                                }
                                TodosLosEntrenadores[0].experienciaentrenador = TodosLosEntrenadores[0].experienciaentrenador - 200;
                            }
                            else
                            {
                                Console.WriteLine("experiencia insuficiente");
                            }
                        }
                        else if (cambiosenamonentrenador == 2) 
                        {
                            if (TodosLosEntrenadores[1].experienciaentrenador >= 200)
                            {
                                Console.WriteLine(" digite el numero de senamon que desea aumentar ");
                                for (int b = 0; b < 5; b++)
                                {
                                    Console.WriteLine($"\n senamon {b} : {TodosLosEntrenadores[1].getvectorsenamon()[b].nombresenamon}\n");
                                }
                                do
                                {
                                    Console.WriteLine("digite la opcion correspondiente");
                                    validacion = int.TryParse(Console.ReadLine(), out cambiosenamon);
                                } while (validacion = false || cambiosenamon < 0 || cambiosenamon > 4);
                                Console.WriteLine($" que estadistica va a aumentar " + $"( 1- ATAQUE  actual {TodosLosEntrenadores[1].getvectorsenamon()[cambiosenamon].puntosdeataque} 2- SALUD actual{TodosLosEntrenadores[1].getvectorsenamon()[cambiosenamon].puntosdesalud} )");
                                do
                                {
                                    Console.WriteLine("digite la opcion correspondiente");
                                    validacion = int.TryParse(Console.ReadLine(), out cambioestadistica);
                                } while (cambioestadistica != 1 && cambioestadistica != 2);
                                if (cambioestadistica == 1)
                                {
                                    TodosLosEntrenadores[1].getvectorsenamon()[cambiosenamon].puntosdeataque = TodosLosEntrenadores[1].getvectorsenamon()[cambiosenamon].puntosdeataque + 20;
                                }
                                else
                                {
                                    TodosLosEntrenadores[1].getvectorsenamon()[cambiosenamon].puntosdeataque = TodosLosEntrenadores[1].getvectorsenamon()[cambiosenamon].puntosdesalud + 20;
                                }
                                TodosLosEntrenadores[1].experienciaentrenador = TodosLosEntrenadores[1].experienciaentrenador - 200;
                            }
                            else
                            {
                                Console.WriteLine("experiencia insuficiente");
                            }
                        }
                        else { Console.WriteLine("usted decidio no cambiar ningun atributo"); }
                        break;
                    case 3:
                        break;
                    case 4:
                        seguir = false;
                        break;
                }
            }
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("LA LISTA DE SENAMONES POR CADA ENTRENADOR SE MODIFICO DE LA SIGUIENTE MANERA");
            for (int i = 0; i < TodosLosEntrenadores.Count; i++)
            {
                Console.WriteLine($"entreador: {TodosLosEntrenadores[i].getNombre()} correo: {TodosLosEntrenadores[i].Correo} fecha de nacimiento {TodosLosEntrenadores[i].Fechadenacimiento.ToShortDateString()} sus puntos de experiencia son: {TodosLosEntrenadores[i].experienciaentrenador} sus batallas ganadas son: {TodosLosEntrenadores[i].cantbatallasganadas}");
                Console.WriteLine("sus senamones son: ");
                for (int b = 0; b < 5; b++)
                {
                    Console.WriteLine($"\n senamon {b + 1} : {TodosLosEntrenadores[i].getvectorsenamon()[b].nombresenamon}  salud: {TodosLosEntrenadores[i].getvectorsenamon()[b].puntosdesalud} ataque: {TodosLosEntrenadores[i].getvectorsenamon()[b].puntosdeataque}\n");
                }
                
            }
        }
    }
}
