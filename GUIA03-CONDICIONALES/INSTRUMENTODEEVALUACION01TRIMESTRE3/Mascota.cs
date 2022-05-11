using System;
using System.Collections.Generic;
using System.Text;

namespace INSTRUMENTODEEVALUACION01TRIMESTRE3
{
    class Mascota
    {
        public string Nombre { get; set; }
        public int Fechadenacimiento { get; set; }
        public string Raza { get; set; }
        public double Peso { get; set; }
        public string Color { get; set; }
        public bool Esteril { get; set; }
        public string Tipomascota { set; get; }
        private string codigoMascota;

        public string getCodigoMascota()
        {
            while (this.codigoMascota == null) { generarCodigo(); }
            return this.codigoMascota;
        }
        private void generarCodigo()
        {
            int codigo;
            Random numero = new Random();
            codigo = numero.Next(10000, 1000000);
            this.codigoMascota = this.Tipomascota + "-" + codigo;
        }
        private List<Vacuna> ListaMascotasv = new List<Vacuna>();
        public List<Vacuna> getListadeMascotasv() { return this.ListaMascotasv; }
        public void agregarMascotasv(Vacuna Mascotav)
        {
            this.ListaMascotasv.Add(Mascotav);
        }
    }
}