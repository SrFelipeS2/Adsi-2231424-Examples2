using System;

namespace EJERCICIO2POOGUIA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador Deportista = new Jugador();
            Console.WriteLine("por fvor ingrese su nombre ");
            Deportista.Nombre = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su edad ");
            Deportista.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su contacto ");
            Deportista.Contacto = long.Parse(Console.ReadLine());
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese el deporte que practica");
            Deportista.Deporte = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su nacionalidad ");
            Deportista.Nacionalidad = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("\n//////////////////////////////////////////////////\n");
            Jugador Deportista1 = new Jugador("DAVID",21,3107885186,"NATACION","CANADIENDSE");
            Console.WriteLine("EL DEPORTISTA NUMERO 1 SE LLAMA " + Deportista.Nombre + " TIENE UNA EDAD DE: " + Deportista.Edad + " SU CONTACTO DE TELEFONO ES: " + Deportista.Contacto + " EL DEPORTE QUE PRACTICA ES: " + Deportista.Deporte + " Y ES DE NACIONALIDAD: " + Deportista.Nacionalidad);
            Console.WriteLine("EL DEPORTISTA NUMERO 2 SE LLAMA " + Deportista1.Nombre + " TIENE UNA EDAD DE: " + Deportista1.Edad + " SU CONTACTO DE TELEFONO ES: " + Deportista1.Contacto + " EL DEPORTE QUE PRACTICA ES: " + Deportista1.Deporte + " Y ES DE NACIONALIDAD: " + Deportista1.Nacionalidad);

        }
    }
}
