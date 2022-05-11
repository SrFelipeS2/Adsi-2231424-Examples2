using System;
using System.Collections.Generic;
using System.Text;

namespace POOEJERCICIO4
{
    class ESTUDIANTES
    {
        
       public string nombre_estudiante {get; set;}
        public double nota1_estudiante {get; set;}
        public double nota2_estudiante {get; set;}
        public double nota3_estudiante {get; set;}

        public double calculo_notas_promedio()
        {
            return (this.nota1_estudiante + this.nota2_estudiante + this.nota3_estudiante) / 3;
        }
    }
}

