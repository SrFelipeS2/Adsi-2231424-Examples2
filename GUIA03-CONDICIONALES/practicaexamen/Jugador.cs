using System;
using System.Collections.Generic;
using System.Text;

namespace practicaexamen
{
    class Jugador
    {
        //salario, impuestos, gastos, si el salario es mayor a 3 millones declara renta con un porcentaje del 10 %
        //estos son atributos
        private string nombre;
        private int numCamiseta;
        public double Salario{ get; set; }
        public double Impuestos { get; set; }
        public double Gastos { get; set; }
        public double DineroRestante { get; set; }
        
        public Jugador() { }


        public void setNombre(string nombret)
        { 
            this.nombre = nombret;
        }
        public string getNnombre()
        {
            return this.nombre;
        }
        
        public int NumCamiseta { get { return this.numCamiseta; } set { this.numCamiseta = value; } }
        //metodo de clase

        public void calcularDineroRestante() 
        {
            this.DineroRestante = this.Salario - this.Impuestos - this.Gastos;
            if (this.Salario > 3000000)
            {
                this.DineroRestante = this.DineroRestante - (this.Salario * 0.10);
            }
        }

    }
}
