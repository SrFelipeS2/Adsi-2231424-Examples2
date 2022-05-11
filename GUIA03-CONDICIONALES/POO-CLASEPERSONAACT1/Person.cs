using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CLASEPERSONAACT1
{
    class Person
    {
        //public int edad { get { return this.edad}; set this.edad = value { if (value > 17) { this.mayorDeEdad = true} }; }
        private string Colordepiel;
        private double altura;
        private string gender;
        private string nacionalidad;
        public string nombre { get; set; }
        public string MetodoColor
        {
            set { this.Colordepiel = value; }
            get { return this.Colordepiel; }
        }

        public void setaltura(double _alt)
        {
            this.altura = _alt;
        }
        public double getaltura()
        {
            return this.altura;
        }

        public string Metodogender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public void setnacionalidad(string _Nac)
        {
            this.nacionalidad = _Nac;
        }
        public string getnacionalidad()
        {
            return this.nacionalidad;
        }
    }
}
