using System;

namespace INSTRUMENTODEEVALUACION01TRIMESTRE
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreM, nombreV, fechaV, raza, color, tipoM, descripcionV, validar, nombrebusqueda;
                int edad, cantMascotas, canidadedad=0, esterilT, dosis, vacunada, cantidaddeesteril=0,cantidadmascotavac = 0;
                double Peso;
                bool esteril, mascotavacunada;

                Mascota[] vectormascotas;
                do
                {
                    Console.Write("INGRESE EL NUMERO DE MASCOTAS QUE VA A INGRESAR: ");
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
                        if (edad > 5)
                        {
                            canidadedad++;
                        }
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
                        cantidaddeesteril++;
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
                        Console.Write("LA MASCOTA ESTA VACUNADA? 1 PARA SI 0 PARA NO: ");
                        _ = int.TryParse(Console.ReadLine(), out vacunada);
                    } while (vacunada < 0 || vacunada > 1);
                    if (vacunada == 1)
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
                            mascotavacunada = true;
                            mascotav.vacunado = mascotavacunada;
                            mascotav.Nombrevacuna = nombreV;
                            mascotav.Fechadeaplicacion = fechaV;
                            mascotav.Descripcionvacuna = descripcionV;
                            mascotav.Numerodedosis = dosis;
                            mascota.agregarMascotasv(mascotav);
                    }
                    else
                    {
                        mascotavacunada = false;
                        
                    if (mascotavacunada == false)
                        {
                        nombreV = "VACIO";
                        fechaV = "VACIO";
                        descripcionV = "VACIO";
                        dosis = 0;
                        Vacuna mascotav = new Vacuna();
                        mascotav.vacunado = mascotavacunada;
                        mascotav.Nombrevacuna = nombreV;
                        mascotav.Fechadeaplicacion = fechaV;
                        mascotav.Descripcionvacuna = descripcionV;
                        mascotav.Numerodedosis = dosis;
                        mascota.agregarMascotasv(mascotav);
                        cantidadmascotavac++;
                        }
                    }
                    vectormascotas[i] = mascota;
                }
            for (int i = 0; i < vectormascotas.Length; i++)
            {
                Console.WriteLine("*******************************************************");

                Console.WriteLine("\nEL NOMBRE DE LA MASCOTA ES: " + vectormascotas[i].Nombre + "\nES UN: " + vectormascotas[i].Tipomascota + "\nLA MASCOTA ES ESTERIL?:"
                    + vectormascotas[i].Esteril + "\nLA MASCOTA ES DE RAZA: " + vectormascotas[i].Raza + "\nLA MASCOTA TIENE UNA EDAD DE: " + vectormascotas[i].Fechadenacimiento+"años"
                    + "\nLA MASCOTA TIENE UN PESO DE: " + vectormascotas[i].Peso +"kilogramos" +"\nEL COLOR DE LA MASCOTA ES: " + vectormascotas[i].Color + "\nEL CODIGO DE LA MASCOTA ES: " + vectormascotas[i].getCodigoMascota()); 
                for (int k = 0; k < vectormascotas[i].getListadeMascotasv().Count; k++)
                {
                    Console.WriteLine("\n esta vacunado? " +vectormascotas[i].getListadeMascotasv()[k].vacunado + "\nEL NOMBRE DE LA VACUNA ES " + vectormascotas[i].getListadeMascotasv()[k].Nombrevacuna + "\nLA FECHA DE APLICACION DE LA VACUNA ES: " 
                        + vectormascotas[i].getListadeMascotasv()[k].Fechadeaplicacion + "\nLA DESCRIPCION DE LA VACUNA ES; " + vectormascotas[i].getListadeMascotasv()[k].Descripcionvacuna + "\nLAS DOSIS APLICADAS SON: " + vectormascotas[i].getListadeMascotasv()[k].Numerodedosis);
                }
            }
            Console.WriteLine("*******************************************************");
            Console.WriteLine("LAS MASCOTAS ESTERILES SON:"+ cantidaddeesteril);
            Console.WriteLine("*******************************************************");
            Console.WriteLine("LAS MASCOTAS QUE NO ESTAN VACUNADAS SON:"+ cantidadmascotavac);
            Console.WriteLine("*******************************************************");
            Console.WriteLine("DESEA BUSCAR ALGUNA MASCOTA QUE YA HAYA  INGRESADO? ");
            validar = Console.ReadLine();
            if (validar == "si"||validar=="SI"|| validar=="Si"|| validar== "sI"||validar=="yes")
            {
                Console.WriteLine("INGRESE EL NOMBRE DE LA MASCOTA:");
                nombrebusqueda = Console.ReadLine();
                for(int q=0; q < vectormascotas.Length; q++)
                {
                    if (vectormascotas[q].Nombre == nombrebusqueda)
                    {
                        Console.WriteLine(vectormascotas[q].Nombre+"\n"+vectormascotas[q].Peso+"\n"
                            +vectormascotas[q].Raza+"\n"+vectormascotas[q].Tipomascota+"\n"+vectormascotas[q].Color+"\n"+vectormascotas[q].Esteril);
                    }
                }
            }
            else
            {
                Console.WriteLine("QUE TENGA BUEN DIA ");
            }
        }


    }
}
