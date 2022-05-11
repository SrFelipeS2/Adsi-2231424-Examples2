using System;

namespace POO
{
    class Program
    {

        static void Main(string[] args)
        {
            // Creación del objeto / Instanciación de la clase Coche
            Coche coche1_obj = new Coche();
            Console.WriteLine("********************");
            Coche coche2_obj = new Coche("Azul", 150);
            Console.WriteLine("********************");
            int velocidad3 = 200; 
            Coche coche3_obj = new Coche("Rojo", velocidad3, 3.5);
            coche3_obj.cilindraje = 1600;
            coche3_obj.MetodoMarca = "Ferrari";
            coche3_obj.MetodoCantPasajeros = -2;
            Console.WriteLine("********************");

            coche2_obj.Avanzar();
            coche3_obj.Avanzar();
            coche2_obj.Parar();

            coche1_obj.setColor("Negro");
            Console.WriteLine("El coche 1 es: " + coche1_obj.getColor());
            Console.WriteLine("********************");
            coche3_obj.showInfo();
            Console.WriteLine("********************");
            Console.WriteLine("La marca es "+coche3_obj.MetodoMarca+" el cilindraje es: " + coche3_obj.cilindraje);
            Console.WriteLine("********************");
            Console.WriteLine("La cantidad de pasajeros es " + coche3_obj.MetodoCantPasajeros);
        }
    }
}
