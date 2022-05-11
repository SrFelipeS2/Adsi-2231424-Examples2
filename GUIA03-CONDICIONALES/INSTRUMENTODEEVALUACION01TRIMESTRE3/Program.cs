using System;

namespace INSTRUMENTODEEVALUACION01TRIMESTRE3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreM, nombreV, fechaV, raza, color, tipoM, descripcionV;
            int edad, cantMascotas, esterilT, dosis, vacunada, cantidadmascotavac = 0;
            double Peso;
            bool esteril, mascotavacunada;

            Mascota[] vectormascotas;
            do
            {
                Console.Write("INGRESE EL NUMERO DE MASCOTAS QUE VA A INGRESAR");
                _ = int.TryParse(Console.ReadLine(), out cantMascotas);
            } while (cantMascotas <= 0);
            vectormascotas = new Mascota[cantMascotas];

            for (int i = 0; i < vectormascotas.Length; i++)
            {

                Console.Write("INGRESE EL NOMBRE DE LA MASCOTA: " + (i + 1) + ": ");
                nombreM = Console.ReadLine();

                Console.Write("INGRESE EL TIPO DE MASCOTA: ");
                tipoM = Console.ReadLine();

                Console.Write("INGRESE LA RAZA DE LA MASCOTA: ");
                raza = Console.ReadLine();
                do
                {
                    Console.Write("INGRESE LA EDAD EN AÑOS DE LA MASCOTA: ");
                    _ = int.TryParse(Console.ReadLine(), out edad);
                } while (edad <= 0);
                do
                {
                    Console.Write("INGRESE EL PESO EN KILOGRAMOS DE LA MASCOTA: ");
                    _ = double.TryParse(Console.ReadLine(), out Peso);
                } while (Peso <= 0);
                Console.Write("INGRESE EL COLOR  DE LA MASCOTA: ");
                color = Console.ReadLine();
                do
                {
                    Console.Write("LA MASCOTA ES ESTERIL 1 PARA SI 0 PARA NO: ");
                    _ = int.TryParse(Console.ReadLine(), out esterilT);
                } while (esterilT < 0 || esterilT > 1);
                if (esterilT == 1)
                {
                    esteril = true;
                }
                else
                {
                    esteril = false;
                }

                Mascota mascota = new Mascota();
                mascota.Nombre = nombreM;
                mascota.Tipomascota = tipoM;
                mascota.Raza = raza;
                mascota.Fechadenacimiento = edad;
                mascota.Peso = Peso;
                mascota.Color = color;
                mascota.Esteril = esteril;
                do
                {
                    Console.WriteLine("LA MASCOTA ESTA VACUNADA? 1 PARA SI 0 PARA NO");
                    _ = int.TryParse(Console.ReadLine(), out vacunada);
                } while (vacunada < 0 || vacunada > 1);
                    if (vacunada == 1)
                    {
                        for (int a = 0; a < cantMascotas; a++)
                        {

                            Console.Write("INGRESE EL NOMBRE DE LA VACUNA: ");
                            nombreV = Console.ReadLine();
                            Console.Write("INGRESE LA FECHA DE APLICACION DIA/MES/AÑO:  ");
                            fechaV = Console.ReadLine();
                            Console.Write("INGRESE UNA BREVE DESCRIPCION DE LA VACUNA: ");
                            descripcionV = Console.ReadLine();
                            do
                            {
                                Console.Write("INGRESE LAS DOSIS QUE TIENE DE LA VACUNA: ");
                                _ = int.TryParse(Console.ReadLine(), out dosis);
                            } while (dosis <= 0);
                            Vacuna mascotav = new Vacuna();
                            mascotav.Nombrevacuna = nombreV;
                            mascotav.Fechadeaplicacion = fechaV;
                            mascotav.Descripcionvacuna = descripcionV;
                            mascotav.Numerodedosis = dosis;
                            mascota.agregarMascotasv(mascotav);
                        }

                    }
                    else
                    {
                        mascotavacunada = false;
                        if (mascotavacunada == false)
                        {
                            cantidadmascotavac++;
                        }
                    }
                vectormascotas[i] = mascota;
            }//cierre del for de los jugadores
            

            }// cierre de ciclo de los n equipos







        }
    }
}



    

