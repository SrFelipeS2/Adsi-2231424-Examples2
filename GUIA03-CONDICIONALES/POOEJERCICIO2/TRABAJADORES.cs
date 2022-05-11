using System;
using System.Collections.Generic;
using System.Text;

namespace POOEJERCICIO2
{
    class TRABAJADORES
    {
        public string nombre_trabajador { get; set; }
        public int numero_identificacion { get; set; }
        public int precio_horas { get; set; }
        public int horas_trabajdas { get; set; }

        public int Calculo_salario()
        {
            return this.precio_horas * this.horas_trabajdas;
        }
    }
}
