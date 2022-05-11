using System;
using System.Collections.Generic;

namespace recuperacion_manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreE, correo;
            int preferencia1, opciongeneral, cambios = 0, cambioS1, reempest;
            bool val, seguir = true;
            DateTime fecahdenacimiento;
            Console.WriteLine("bienvenido al juego de los senamones");
            entrenador entreador;
            List<senamon> TodosLosSenamones = new List<senamon>();
            List<entrenador> TodosLosEntrenadores = new List<entrenador>();

            senamon senamon1 = new senamon("Beedrill", "electrico", 10.5, 110, 70, 1, "senamon 001");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Pidgey", "electrico", 5, 95, 45, 1, "senamon 002");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Pidgeotto", "hierva", 20, 100, 45, 1, "senamon 003");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Pidgeot", "hierva", 3, 80, 35, 1, "senamon 004");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Rattata", "Agua", 15, 60, 77, 2, "senamon 005");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Raticate", "Agua", 10, 100, 60, 1, "senamon 006");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Spearow", "fuego", 5, 125, 65, 1, "senamon 007");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Venomoth", "fuego", 8, 96, 75, 2, "senamon 008");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Geodude", "Aire", 2, 127, 35, 1, "senamon 009");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Graveler", "aire", 40, 100, 95, 3, "senamon 010");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Rapidash", "electrico", 48, 95, 50, 1, "senamon 011");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Slowpoke", "electrico", 20, 100, 25, 1, "senamon 012");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Slowbro", "hierva", 30, 126, 85, 3, "senamon 013");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Magnemite", "hierva", 40, 96, 62, 1, "senamon 014");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Doduo", "agua", 25, 133, 43, 1, "senamon 015");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Seel", "agua", 65, 98, 69, 1, "senamon 016");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Gengar", "fuego", 55, 100, 45, 1, "senamon 017");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Lavasick", "fuego", 23, 128, 30, 1, "senamon 018");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Hypno", "aire", 43, 100, 59, 1, "senamon 019");
            TodosLosSenamones.Add(senamon1);
            senamon1 = new senamon("Voltorb", "aire", 25, 100, 90, 3, "senamon 020");
            TodosLosSenamones.Add(senamon1);

            
            //ingresar entrenador y seleccion de senamones
            for (int i = 0; i < 2; i++)
            {
                Console.Write("ingrese el nombre del entrenador:");
                nombreE = Console.ReadLine();
                Console.Write("ingrese el email:");
                correo = Console.ReadLine();
                Console.WriteLine("ingrese la fecha de nacimiento del entrenador:");
                _ = DateTime.TryParse(Console.ReadLine(), out fecahdenacimiento);
                entreador = new entrenador(nombreE, correo, fecahdenacimiento);
                Console.WriteLine("elija sus senamon ");
                for (int a = 0; a < TodosLosSenamones.Count; a++)
                {
                    Console.WriteLine($" {a} nombre: {TodosLosSenamones[a].nombresenamon} salud: {TodosLosSenamones[a].puntosdesalud} ataque: {TodosLosSenamones[a].puntosdeataque}");
                }
                for (int k = 0; k < 5; k++)
                {
                    while (true)
                    {
                        val = int.TryParse(Console.ReadLine(), out preferencia1);
                        if (val == true && preferencia1 >= 0 && preferencia1 <= TodosLosSenamones.Count)
                        {
                            entreador.setsenamon(TodosLosSenamones[preferencia1]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("ingreso mal el digito");
                        }
                    }

                }
                TodosLosEntrenadores.Add(entreador);
            }

            for (int i = 0; i < TodosLosEntrenadores.Count; i++)
            {
                Console.WriteLine($"entreador: {TodosLosEntrenadores[i].getNombre()} correo: {TodosLosEntrenadores[i].Correo} fecha de nacimiento {TodosLosEntrenadores[i].Fechadenacimiento.ToShortDateString()}");
                Console.WriteLine("sus senamones son: ");
                for (int b = 0; b < 5; b++)
                {
                    Console.WriteLine($" senamon {b + 1} : {TodosLosEntrenadores[i].getvectorsenamon()[b].nombresenamon}");
                }
            }
            while (seguir == true)
            {
                Console.WriteLine("menu general");
                Console.WriteLine("1 - para reemplazar senamon");
                Console.WriteLine("2 - para aumentar estadisticas");
                Console.WriteLine("3 - iniciar batalla");
                Console.WriteLine("4 - finalizar");
                do
                {
                    Console.WriteLine("digite la opcion correspondiente");
                    val = int.TryParse(Console.ReadLine(), out opciongeneral);
                } while (val = false || opciongeneral < 1 || opciongeneral > 4);
                switch (opciongeneral)
                {
                    case 1:
                        Console.Write($"digite el numero del entrenador que cambiara sus senamones" + $"( 1- {TodosLosEntrenadores[0].getNombre()} 2- {TodosLosEntrenadores[1].getNombre()} 3- para cancelar )");
                        do
                        {
                            Console.WriteLine("digite la opcion correspondiente");
                            val = int.TryParse(Console.ReadLine(), out cambios);
                        } while (cambios != 1 && cambios != 2 && cambios != 3);
                        if (cambios == 1)
                        {
                            Console.WriteLine(" digite el numero de senamon que desea cambiar ");
                            for (int b = 0; b < 5; b++)
                            {
                                Console.WriteLine($"\n senamon {b} : {TodosLosEntrenadores[0].getvectorsenamon()[b].nombresenamon}\n");
                            }
                            do
                            {
                                val = int.TryParse(Console.ReadLine(), out cambioS1);
                            } while (val = false || cambioS1 < 0 || cambioS1 > 4);
                            TodosLosEntrenadores[0].eliminarsenamon(cambioS1);
                            Console.WriteLine("elija 1 senamon ");
                            for (int a = 0; a < TodosLosSenamones.Count; a++)
                            {
                                Console.WriteLine($" {a} nombre: {TodosLosSenamones[a].nombresenamon} salud: {TodosLosSenamones[a].puntosdesalud} ataque: {TodosLosSenamones[a].puntosdeataque}");
                            }
                            do
                            {
                                Console.WriteLine("escriba el numero de senamon ");
                                val = int.TryParse(Console.ReadLine(), out cambioS1);
                            } while (val = false || cambioS1 < 0 || cambioS1 > TodosLosSenamones.Count);
                            TodosLosEntrenadores[0].setsenamon(TodosLosSenamones[cambioS1]);
                        }
                        else if (cambios == 2)
                        {
                            Console.WriteLine(" digite el numero de senamon que desea cambiar ");
                            for (int b = 0; b < 5; b++)
                            {
                                Console.WriteLine($"\n senamon {b} : {TodosLosEntrenadores[1].getvectorsenamon()[b].nombresenamon}\n");
                            }
                            do
                            {
                                val = int.TryParse(Console.ReadLine(), out cambioS1);
                            } while (val = false || cambioS1 < 0 || cambioS1 > 4);
                            TodosLosEntrenadores[1].eliminarsenamon(cambioS1);
                            Console.WriteLine("DE LA SIGUIENTE LISTA ELIJA 1 ");
                            for (int a = 0; a < TodosLosSenamones.Count; a++)
                            {
                                Console.WriteLine($" {a} nombre: {TodosLosSenamones[a].nombresenamon} salud: {TodosLosSenamones[a].puntosdesalud} ataque: {TodosLosSenamones[a].puntosdeataque}");
                            }
                            do
                            {
                                Console.WriteLine("DIGITE EL NUMERO CORRESPONDIENTE DEL SENAMON ");
                                val = int.TryParse(Console.ReadLine(), out cambioS1);
                            } while (val = false || cambioS1 < 0 || cambioS1 > TodosLosSenamones.Count);
                            TodosLosEntrenadores[1].setsenamon(TodosLosSenamones[cambioS1]);
                        }
                        else
                        { Console.WriteLine("se canselo la operacion"); }
                        break;
                    case 2:
                        Console.Write($"digite el numero del entrenador que aumentara la estadistica de un senamon" + $"( 1- {TodosLosEntrenadores[0].getNombre()} 2- {TodosLosEntrenadores[1].getNombre()} 3- para cancelar )");
                        do
                        {
                            Console.WriteLine("digite la opcion ");
                            val = int.TryParse(Console.ReadLine(), out cambios);
                        } while (cambios != 1 && cambios != 2 && cambios != 3);
                        if (cambios == 1)
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
                                    Console.WriteLine("digite la opcion ");
                                    val = int.TryParse(Console.ReadLine(), out cambioS1);
                                } while (val = false || cambioS1 < 0 || cambioS1 > 4);
                                Console.WriteLine($" que estadistica va a aumentar " + $"( 1- ATAQUE  actual {TodosLosEntrenadores[0].getvectorsenamon()[cambioS1].puntosdeataque} 2- SALUD actual{TodosLosEntrenadores[0].getvectorsenamon()[cambioS1].puntosdesalud} )");
                                do
                                {
                                    Console.WriteLine("digite la opcion ");
                                    val = int.TryParse(Console.ReadLine(), out reempest);
                                } while (reempest != 1 && reempest != 2);
                                if (reempest == 1)
                                {
                                    TodosLosEntrenadores[0].getvectorsenamon()[cambioS1].puntosdeataque = TodosLosEntrenadores[0].getvectorsenamon()[cambioS1].puntosdeataque + 20;
                                }
                                else
                                {
                                    TodosLosEntrenadores[0].getvectorsenamon()[cambioS1].puntosdeataque = TodosLosEntrenadores[0].getvectorsenamon()[cambioS1].puntosdesalud + 20;
                                }
                                TodosLosEntrenadores[0].experienciaentrenador = TodosLosEntrenadores[0].experienciaentrenador - 200;
                            }
                            else
                            {
                                Console.WriteLine("experiencia insuficiente");
                            }
                        }
                        else if (cambios == 2)
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
                                    Console.WriteLine("digite la opcion ");
                                    val = int.TryParse(Console.ReadLine(), out cambioS1);
                                } while (val = false || cambioS1 < 0 || cambioS1 > 4);
                                Console.WriteLine($" que estadistica va a aumentar " + $"( 1- ATAQUE  actual {TodosLosEntrenadores[1].getvectorsenamon()[cambioS1].puntosdeataque} 2- SALUD actual{TodosLosEntrenadores[1].getvectorsenamon()[cambioS1].puntosdesalud} )");
                                do
                                {
                                    Console.WriteLine("digite la opcion");
                                    val = int.TryParse(Console.ReadLine(), out reempest);
                                } while (reempest != 1 && reempest != 2);
                                if (reempest == 1)
                                {
                                    TodosLosEntrenadores[1].getvectorsenamon()[cambioS1].puntosdeataque = TodosLosEntrenadores[1].getvectorsenamon()[cambioS1].puntosdeataque + 20;
                                }
                                else
                                {
                                    TodosLosEntrenadores[1].getvectorsenamon()[cambioS1].puntosdeataque = TodosLosEntrenadores[1].getvectorsenamon()[cambioS1].puntosdesalud + 20;
                                }
                                TodosLosEntrenadores[1].experienciaentrenador = TodosLosEntrenadores[1].experienciaentrenador - 200;
                            }
                            else
                            {
                                Console.WriteLine("no tiene experiencia");
                            }
                        }
                        else { Console.WriteLine("no se cambiaron atributos"); }
                        break;
                    case 3:
                        break;
                    case 4:
                        seguir = false;
                        break;
                }
            }
            
        }
    }
}
