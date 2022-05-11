using System;
using System.Collections.Generic;
using System.Text;

namespace POOEJERCICIO1
{
    class EMPLEADO
    {
        private string nombre_empleado;
        private string email_empleado;
        private int gastos_empleado;
        private int identificacion_empleado;
        public int salario_empleado { get; set; }/*METODO SALARIO PARA EL EMPLADO*/
        public long telefono_empleado { get; set; }/*METODO PARA TELEFONO DEL EMPLEADO*/

        public EMPLEADO(){}

        public EMPLEADO(string nombre_empleado, int identificacion_empleado) 
        {
            this.identificacion_empleado = identificacion_empleado;
            this.nombre_empleado = nombre_empleado;
        }
        public EMPLEADO(string nombre_empleado, int identificacion_empleado, string email_empleado, long telefono_empleado)
        {
            this.identificacion_empleado = identificacion_empleado;
            this.nombre_empleado = nombre_empleado;
            this.telefono_empleado = telefono_empleado;
            this.email_empleado = email_empleado;
        }
        public string Metodo_nombre_empleado /*METODO PARA EL OBTENER Y MOSTRAR EL NOMBRE DEL EMPLEADO*/
        {
            get { return this.nombre_empleado; }
            set { this.nombre_empleado = value; }
        }


        public string Metodo_email_empleado /*METODO PARA EL OBTENER Y MOSTRAR EL EMAIL DEL EMPLEADO*/
        {
            get { return this.email_empleado; }
            set { this.email_empleado = value; }
        }

        public void setgastos_empleado(int gastos)/*METODO PARA EL OBTENER LOS GASTOS  DEL EMPLEADO*/
        {
            this.gastos_empleado = gastos;
        }

        public int getgastos_empleado()/*METODO PARA MOSTRAR LOS GASTOS  DEL EMPLEADO*/
        {
            return this.gastos_empleado;
        }

        public void setIdentificacion(int identificacion)/*METODO PARA EL OBTENER LA IDENTIFICACION  DEL EMPLEADO*/
        {
            this.identificacion_empleado = identificacion;
        }

        public int getIdentificacion()/*METODO PARA MOSTRAR LA IDENTIFICACION DEL EMPLEADO*/
        {
            return this.identificacion_empleado;
        }
        public int calculo_salario_restante()/*METODO PARA MOSTRAR EL CALCULO DEL SALARIO RESTANTE DEL DEL EMPLEADO*/
        {
            return  this.salario_empleado - this.gastos_empleado;
        }

    }
}
