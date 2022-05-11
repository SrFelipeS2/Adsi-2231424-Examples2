using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Coche
    {
        // Atributos
        private string color;// el private se usa solamente cuando se declaran variables al inicio y despues se declaran los metodos 
        private int velocidad;
        private double tamaño;
        public int cilindraje { get; set; }// de esta manera se declara la variable o atributo de la clase y al mismo tiempo se genera metodos de get y set
        private string _marca;
        public string MetodoMarca //public significa que cualquier clase puede acceder a la variable
        {
            get { return this._marca; }
            set { this._marca = value; }
        }
        private int _cantPasajeros;
        public int MetodoCantPasajeros
        {
            get { return this._cantPasajeros; }
            set
            {
                if(value > 0)
                {
                    this._cantPasajeros = value;
                }
            }
        }

        // Método constructor
        public Coche() // Constructor vacío
        {
            Console.WriteLine("Se instanció el objeto con el constructor vacío");
        }

        // Constructor con 3 parámetros
        public Coche(string color, int _vel, double _tam)
        {
            this.color = color;
            this.velocidad = _vel;
            this.tamaño = _tam;
            Console.WriteLine("Se instanció el objeto con constructor 3 parámetros");
        }
        
        // Constructor con 2 parámetros
        public Coche(string _col, int _vel)
        {
            this.color = _col;
            this.velocidad = _vel;
            Console.WriteLine("Se instanció el objeto con constructor 2 parámetros");
        }

        // Métodos de la clase - se ejecutan después de creación del objeto
        public void Avanzar()
        {
            Console.WriteLine("El coche "+ this.color +" avanza...");
        }
        public void Parar()
        {
            Console.WriteLine("El coche " + this.color + " para...");
        }

        // Métodos SET y GET para Asignar/Acceder a los atributos
        // Método SET y GET para color
        public void setColor(string _col)
        {
            this.color = _col;
        }
        public string getColor()
        {
            return this.color;
        }
        // Método SET y GET para velocidad
        public void setVelocidad(int _vel)
        {
            this.velocidad = _vel;
        }
        public int getVelocidad()
        {
            return this.velocidad;
        }

        // Métodos propios de la Clase
        public void showInfo()
        {
            Console.WriteLine("El carro es "+this.color+ " tiene una velocidad de "+ this.velocidad+ " y tiene un tamaño de: "+this.tamaño);
        }

    }
}
