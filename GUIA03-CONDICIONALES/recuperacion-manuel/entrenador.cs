using System;
using System.Collections.Generic;
using System.Text;

namespace recuperacion_manuel
{
    class entrenador
    {
        private senamon[] vecsen = new senamon[5];
        public senamon[] getvectorsenamon()
        {
            return this.vecsen;
        }
        public void setsenamon(senamon senamon)
        {
            for (int i = 0; i < vecsen.Length; i++)
            {
                if (vecsen[i] == null)
                {
                    vecsen[i] = senamon;
                    break;
                }
            }
        }
        public void eliminarsenamon(int pos)
        {
            this.vecsen[pos] = null;
        }
        public void aumentarvictoria()
        {
            this.cantbatallasganadas++;
            this.experienciaentrenador = this.experienciaentrenador + 100;
        }
        private string nombre;
        private string email;
        public DateTime Fechadenacimiento { get; set; }
        public int experienciaentrenador { get; set; }
        public int cantbatallasganadas { get; set; }

        public entrenador(string nombre, string email, DateTime fechadenacimiento)
        {
            this.nombre = nombre;
            this.email = email;
            this.Fechadenacimiento = fechadenacimiento;
            this.cantbatallasganadas = 0;
            this.experienciaentrenador = 0;
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
      
    }
}
