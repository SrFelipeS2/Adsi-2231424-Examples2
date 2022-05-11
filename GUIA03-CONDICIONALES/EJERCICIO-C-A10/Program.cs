using System;

class MainClass
{
    public static void Main(string[] args)
    {
    /*Tomando como base los resultados obtenidos en un laboratorio de análisis clínicos,
      un medico determina si una persona esta normal, tiene anemia o tiene cardiopatía lo cual
      depende de su nivel de hemoglobina en la sangre, de su edad y de su sexo.Si el nivel de hemoglobina
      que tiene una persona es menor que el rango que le corresponde, se determina su resultado como Anemia, 
      si esta dentro del rango, se determina su resultado como Normal y si esta por encima del rango, se determina 
      su resultado como Cardiopatía.La tabla en la que el medico se basa para obtener el resultado es la siguiente:*/

   string gen = "";
        double meses = 0;
        double nivelHemo;
        double años = 0;
        int opcEdad;

        Console.WriteLine("Digite la opcion segun corresponda la edad 1 -> meses 2 -> años");
        opcEdad = int.Parse(Console.ReadLine());

        if (opcEdad == 1)
        {
            Console.WriteLine("Digite la cantidad de meses");
            meses = double.Parse(Console.ReadLine());
        }
        else if (opcEdad == 2)
        {
            Console.WriteLine("Digite la cantidad de años");
            años = double.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("La opción que digitó no es válida");
        }

        Console.WriteLine("Digite el nivel de hemoglobina");
        nivelHemo = double.Parse(Console.ReadLine());

        if (años > 15)
        {
            Console.WriteLine("Digite la opción según corresponda su genero h-> Hombre    m-> mujer");
            gen = Console.ReadLine();
        }
        if (meses >= 0 && meses <= 1 && nivelHemo < 13)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (meses >= 0 && meses <= 1 && nivelHemo >= 13 && nivelHemo <= 26)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (meses >= 0 && meses <= 1 && nivelHemo > 26)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }

        if (meses > 1 && meses <= 6 && nivelHemo < 10)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (meses > 1 && meses <= 6 && nivelHemo >= 11 && nivelHemo <= 18)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (meses > 1 && meses <= 6 && nivelHemo > 18)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }

        if (meses > 1 && meses <= 6 && nivelHemo < 10)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (meses > 1 && meses <= 6 && nivelHemo >= 10 && nivelHemo <= 18)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (meses > 1 && meses <= 6 && nivelHemo > 18)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }

        if (meses > 6 && meses <= 12 && nivelHemo < 11)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (meses > 6 && meses <= 12 && nivelHemo >= 11 && nivelHemo <= 15)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (meses > 6 && meses <= 12 && nivelHemo > 15)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }

        if (años > 1 && años <= 5 && nivelHemo < 11.5)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (años > 1 && años <= 5 && nivelHemo >= 11.5 && nivelHemo <= 15)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (años > 1 && años <= 5 && nivelHemo > 15)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }

        if (años > 5 && años <= 10 && nivelHemo < 12.6)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (años > 5 && años <= 10 && nivelHemo >= 12.6 && nivelHemo <= 15.5)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (años > 5 && años <= 10 && nivelHemo > 15.5)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }

        if (años > 10 && años <= 15 && nivelHemo < 13)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (años > 10 && años <= 15 && nivelHemo >= 13 && nivelHemo <= 15.5)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (años > 10 && años <= 15 && nivelHemo > 15.5)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }

        if (gen == "h" && nivelHemo < 14)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (gen == "h" && nivelHemo >= 14 && nivelHemo <= 18)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (gen == "h" && nivelHemo > 18)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }

        if (gen == "m" && nivelHemo < 12)
        {
            Console.WriteLine("Su diagnostico es: Anemia.");
        }
        else if (gen == "m" && nivelHemo >= 12 && nivelHemo <= 16)
        {
            Console.WriteLine("Su diagnostico es: Normal.");
        }
        else if (gen == "m" && nivelHemo > 16)
        {
            Console.WriteLine("Su diagnostico es: Cardiopatía");
        }
    }
}