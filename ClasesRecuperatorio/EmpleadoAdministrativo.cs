using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRecuperatorio
{
    public class EmpleadoAdministrativo : Empleado
    {
        public int Antiguedad { get; set; }
       
        public EmpleadoAdministrativo(string nombre, int DNI, string Apellido, string Tipo) : base(nombre, DNI, Apellido)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.Apellido = Apellido;
            this.Tipo = Tipo;
        }
       
    }
}
