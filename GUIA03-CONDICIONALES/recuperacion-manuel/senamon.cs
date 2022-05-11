using System;
using System.Collections.Generic;
using System.Text;

namespace recuperacion_manuel
{
    class senamon
    {
        public string nombresenamon { get; set; }
        public string tipo { get; set; }
        public double peso { get; set; }
        public int puntosdesalud { get; set; }
        public int puntosdeataque { get; set; }
        public int faseevo { get; set; }

        public string descripcion { get; set; }
        public senamon() { }
        public senamon(string nombre, string tipo, double peso, int salud, int ataque, int faseevo, string descripcion)
        {
            this.nombresenamon = nombre;
            this.peso = peso;
            this.tipo = tipo;
            this.faseevo = faseevo;
            this.puntosdeataque = ataque;
            this.puntosdesalud = salud;
            this.descripcion = descripcion;
        }
    }
}
