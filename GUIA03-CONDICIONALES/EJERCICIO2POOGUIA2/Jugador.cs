using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO2POOGUIA2
{
    class Jugador
    {
        public string Nombre { set; get; }
        public int Edad { set; get; }
        public long Contacto{ set; get; }
        public string Deporte { set; get; }
        public string Nacionalidad { set; get; }

        public Jugador() { }
        public Jugador(string nombre, int edad, long contacto, string deporte, string nacionalidad) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Contacto = contacto;
            this.Deporte = deporte;
            this.Nacionalidad = nacionalidad;
        }

    }
}
