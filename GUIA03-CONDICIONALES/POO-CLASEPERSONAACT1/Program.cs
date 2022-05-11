using System;

namespace POO_CLASEPERSONAACT1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Person Persona1 = new Person();
            Person Persona2 = new Person();
            Person Persona3 = new Person();
            Console.WriteLine("por fvor ingrese su nombre ");
            Persona1.nombre = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su color de piel ");
            Persona1.MetodoColor = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su altura EN CM ");
            _ = double.TryParse(Console.ReadLine(), out  double centimetros);
            Persona1.setaltura(centimetros);
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su genero ");
            Persona1.Metodogender = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su nacionalidad");
            Persona1.setnacionalidad(Console.ReadLine());
            Console.WriteLine("******************************************************************");
            Console.WriteLine("por fvor ingrese su nombre ");
            Persona2.nombre = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su color de piel ");
            Persona2.MetodoColor = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su altura ");
            Persona2.setaltura(double.Parse(Console.ReadLine()));
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su genero ");
            Persona2.Metodogender = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su nacionalidad");
            Persona2.setnacionalidad(Console.ReadLine());
            Console.WriteLine("******************************************************************");
            Console.WriteLine("por fvor ingrese su nombre ");
            Persona3.nombre = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su color de piel ");
            Persona3.MetodoColor = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su altura ");
            Persona3.setaltura(double.Parse(Console.ReadLine()));
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su genero ");
            Persona3.Metodogender = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("por fvor ingrese su nacionalidad");
            Persona3.setnacionalidad(Console.ReadLine());
            Console.WriteLine("********************************************************************");
            Console.WriteLine("la persona tiene las siguientes caracteristicas su nombre es: " + Persona1.nombre + " su color de piel es: " + Persona1.MetodoColor + " su altura es: " + Persona1.getaltura() + " su nacionalidad es: " + Persona1.getnacionalidad() + " su genero es: " + Persona1.Metodogender);
            Console.WriteLine("la persona tiene las siguientes caracteristicas su nombre es: " + Persona2.nombre + " su color de piel es: " + Persona2.MetodoColor + " su altura es: " + Persona2.getaltura() + " su nacionalidad es: " + Persona2.getnacionalidad() + " su genero es: " + Persona2.Metodogender);
            Console.WriteLine("la persona tiene las siguientes caracteristicas su nombre es: " + Persona3.nombre + " su color de piel es: " + Persona3.MetodoColor + " su altura es: " + Persona3.getaltura() + " su nacionalidad es: " + Persona3.getnacionalidad() + " su genero es: " + Persona3.Metodogender);
        }
    }
}
