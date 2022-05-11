using System;
using System.Collections.Generic;
using System.Text;

namespace RECUPERACIONPOOFASE1
{
    class Senamon
    {
        public int fase { get; set; }
        public string tipo { get; set; }
        public double peso { get; set; }
        public int puntosdesalud { get; set; }
        public string nombresenamon { get; set; }
        public int puntosdeataque { get; set; }
        
     
        public string descripcion { get; set; }
        public Senamon() { }
        public Senamon(string nombre, string tipo, double peso, int salud, int ataque,int faseevo, string descripcion)
        {
            this.nombresenamon = nombre;
            this.peso = peso;
            this.tipo = tipo;
            this.fase = faseevo;
            this.puntosdeataque = ataque;
            this.puntosdesalud = salud;
            this.descripcion = descripcion;
        }
    }
}
