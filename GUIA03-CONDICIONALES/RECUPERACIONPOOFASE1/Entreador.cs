using System;
using System.Collections.Generic;
using System.Text;

namespace RECUPERACIONPOOFASE1
{
    class Entreador
    {
        private Senamon[] vectorsenamon = new Senamon[5];
        private string nombre;
        private string email;
        public DateTime Fechadenacimiento { get; set; }
        public int experienciaentrenador { get; set; }
        public int cantbatallasganadas { get; set; }

        public Entreador(string nombre, string email, DateTime fechadenacimiento)
        {
            this.nombre = nombre; 
            this.email = email; 
            this.Fechadenacimiento = fechadenacimiento;
            this.cantbatallasganadas = 0;
            this.experienciaentrenador = 400;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string var1)
        {
            this.nombre = var1;
        }
        public string Correo
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public Senamon[] getvectorsenamon()
        {
            return this.vectorsenamon;
        }
        public void setsenamon(Senamon senamon)
        {
            for (int i = 0; i < vectorsenamon.Length; i++)
            {
                if (vectorsenamon[i] == null)
                {
                    vectorsenamon[i] = senamon;
                    break;
                }
            }
        }
        public void eliminarsenamon(int posicion){
            this.vectorsenamon[posicion] = null;
        }
        public void aumentarvictoria()
        {
            this.cantbatallasganadas++;
            this.experienciaentrenador = this.experienciaentrenador + 100;
        }
    }
}
