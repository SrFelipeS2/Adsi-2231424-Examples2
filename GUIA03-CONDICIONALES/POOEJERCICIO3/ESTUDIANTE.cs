using System;
using System.Collections.Generic;
using System.Text;

namespace POOEJERCICIO3
{
    class ESTUDIANTE
    /*Realizar la clase estudiante y declarar 5 instancias de la misma. Por cada uno de los
estudiantes, el sistema deberá decir quienes pasaron y quiénes no. Para ello cada
estudiante tendrá 3 notas y la nota final será el promedio de todas las notas. Pasarán
aquellos estudiantes que tengan la nota final por encima de 3.5. Tener en cuenta las
siguientes notas por cada estudiante:*/
    {
       public string nombre_estudiante { get; set; }
       public double nota1_estudiante { get; set; }
       public double nota2_estudiante { get; set; }
       public double nota3_estudiante { get; set; }

        public double calculo_notas_promedio()
        {
            return (this.nota1_estudiante + this.nota2_estudiante + this.nota3_estudiante) / 3;
        }
    }
}
