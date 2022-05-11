using System;
using System.Collections;

namespace RULETADETEMAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnostotal, temastotal,continuar=0;
            Console.WriteLine("*********************************");
            ArrayList INDICES = new ArrayList();
            ArrayList TEMAS= new ArrayList();
            TEMAS.Add("Que es la Programación Orientada a Objetos POO");
            TEMAS.Add("Diferencias entre la programación estructurada y la Programación");
            TEMAS.Add("Abstracción en POO");
            TEMAS.Add("Encapsulación en POO");
            TEMAS.Add("Herencia en POO");
            TEMAS.Add("Polimorfismo en POO");
            TEMAS.Add("que es un diagrama de Clases");
            Console.WriteLine("*********************************");
            ArrayList estudiantes = new ArrayList();
            estudiantes.Add("ALEJANDRO CARDONA LOPEZ");
            estudiantes.Add("ALEJANDRO GIL GARCIA");
            estudiantes.Add("ANDRES FELIPE VALENCIA LOPEZ");
            estudiantes.Add("ANDRES FELIPE ALZATE ALARCON");
            estudiantes.Add("ANDRES MAURICIO CIFUENTES SILVA");
            estudiantes.Add("ANGIE TATIANA MAYORGA MAYORGA");
            estudiantes.Add("DAHIANA OROZCO OROZCO");
            estudiantes.Add("DANIEL HOLGUIN GARCIA");
            estudiantes.Add("DANIEL GONZALEZ CEBALLOS");
            estudiantes.Add("DANIEL EDUARDO BELTRAN GRISALES");
            estudiantes.Add("DAVID SANTIAGO LEGUIZAMON GUERRA");
            estudiantes.Add("FEDERICO KRASTZ ROMAN");
            estudiantes.Add("JHON DARWIN GRISALES GIRALDO");
            estudiantes.Add("JUAN DIEGO YEPES ARANGO");
            estudiantes.Add("JUAN MANUEL ALZATE GALVEZ");
            estudiantes.Add("LUIS FELIPE CASTAÑEDA GALVIS");
            estudiantes.Add("LUISA FERNANDA YAQUIVE HOYOS");
            estudiantes.Add("MANUEL SABOGAL ARDILA");
            estudiantes.Add("MARIA PAULINA CASTRO LOPEZ");
            estudiantes.Add("MICHAEL JARAMILLO HENAO");
            estudiantes.Add("NICOL DAHIANNA QUIJANO LADINO");
            estudiantes.Add("SEBASTIAN SANCHEZ TABORDA");
            estudiantes.Add("SIMON TORO CUERVO");
            estudiantes.Add("WESNER DAMIAN GARCES LORA");
            estudiantes.Add("YESICA ANDREA GUTIERREZ ESCOBAR");
            while (continuar!=1)
            {
                Console.WriteLine("BUEN Dia la lista de estudiantes esta conformada por los siguientes integrantes: ");
                foreach (string mostrar in estudiantes)
                {
                    Console.WriteLine("estudiante: " + mostrar);
                }
                Console.WriteLine("*********************************");
                Console.WriteLine("desea agregar algun estudiante? digite 1 para SI o 2 para NO");
                _ = int.TryParse(Console.ReadLine(), out int agregar);
                if (agregar == 1)
                {
                    Console.WriteLine("digite la cantidad de alumnos que desea garegar");
                    _ = int.TryParse(Console.ReadLine(), out int alumnos);
                    for (int i = 0; i < alumnos; i++)
                    {
                        Console.WriteLine("Ingrese el nombre del estudiante");
                        estudiantes.Add(Console.ReadLine());
                    }
                    Console.WriteLine("La lista quedo de la siguiente manera:");
                    Console.WriteLine("*********************************");
                    foreach (string mostrar in estudiantes)
                    {
                        Console.WriteLine("estudiante: " + mostrar);
                    }
                }
                else
                {
                    Console.WriteLine("*********************************");
                    Console.WriteLine("no se agregaron mas estudiantes.");
                    Console.WriteLine("*********************************");
                }
                alumnostotal = estudiantes.Count;
                Console.WriteLine("el numero total de estudiantes es: " + alumnostotal);
                Console.WriteLine("*********************************");
                Console.WriteLine("El listado de temas que hay para las expocisiones son: ");
                Console.WriteLine("*********************************");
                foreach (string mostrar in TEMAS)
                {
                    Console.WriteLine("tema: " + mostrar);
                }
                temastotal = TEMAS.Count;
                Console.WriteLine("el numero total de TEMAS es: " + temastotal);
                Console.WriteLine("*********************************");
                /*4*4 y 3*3*/
                
                //si agrego un estudiante 

                for (int i = 0; i < 3; i++)//se muestra del grupo 5 al grupo 7 
                {
                    int indiceEst, indiceEst1, indiceEst2;
                    Random r = new Random();
                    indiceEst = r.Next(0, estudiantes.Count);
                    indiceEst1 = r.Next(0, estudiantes.Count);
                    indiceEst2 = r.Next(0, estudiantes.Count);

                    //Console.WriteLine("grupo " + indiceEst + ", " + indiceEst1 + ", " + indiceEst2 );
                    if (!INDICES.Contains(indiceEst2) && !INDICES.Contains(indiceEst1) && !INDICES.Contains(indiceEst) && indiceEst1 != indiceEst && indiceEst1 != indiceEst2 && indiceEst2 != indiceEst && indiceEst2 != indiceEst1)
                    {
                        Console.WriteLine("\n el grupo numero " + (i+1) + " con el tema " + TEMAS[i] + " quedo conformado de la siguiente manera.");
                        Console.WriteLine(estudiantes[indiceEst]);
                        INDICES.Add(indiceEst);
                        Console.WriteLine(estudiantes[indiceEst1]);
                        INDICES.Add(indiceEst1);
                        Console.WriteLine(estudiantes[indiceEst2]);
                        INDICES.Add(indiceEst2);

                    }
                    else
                    {
                        i--;
                    }
                }
                for (int i = 4; i < 8; i++)
                {
                    int indiceEst, indiceEst1, indiceEst2, indiceEst3;
                    Random r = new Random();
                    indiceEst = r.Next(0, estudiantes.Count);
                    indiceEst1 = r.Next(0, estudiantes.Count);
                    indiceEst2 = r.Next(0, estudiantes.Count);
                    indiceEst3 = r.Next(0, estudiantes.Count);
                    //Console.WriteLine("grupo " + indiceEst + ", " + indiceEst1+ ", " + indiceEst2+ ", " + indiceEst3);
                    if (!INDICES.Contains(indiceEst3) && !INDICES.Contains(indiceEst2) && !INDICES.Contains(indiceEst1) && !INDICES.Contains(indiceEst) && indiceEst1 != indiceEst && indiceEst1 != indiceEst2 && indiceEst1 != indiceEst3 && indiceEst2 != indiceEst && indiceEst2 != indiceEst1 && indiceEst2 != indiceEst3 && indiceEst3 != indiceEst && indiceEst3 != indiceEst1 && indiceEst3 != indiceEst2)
                    {
                        Console.WriteLine("\n el grupo numero " + (i) + " con el tema " + TEMAS[i-1] + " quedo conformado de la siguiente manera:");
                        Console.WriteLine(estudiantes[indiceEst]);
                        INDICES.Add(indiceEst);
                        Console.WriteLine(estudiantes[indiceEst1]);
                        INDICES.Add(indiceEst1);
                        Console.WriteLine(estudiantes[indiceEst2]);
                        INDICES.Add(indiceEst2);
                        Console.WriteLine(estudiantes[indiceEst3]);
                        INDICES.Add(indiceEst3);
                    }
                    else
                    {
                        i--;
                    }
                }
                Console.WriteLine("*********************************");
                Console.WriteLine("esta deacuerdo con la asignacion de grupos y reparticion de temas? digite 1 para si ò 0 para sortear de nuevo.");
                _ = int.TryParse(Console.ReadLine(), out continuar);
                INDICES.Clear();
            }



        }
    }
}
