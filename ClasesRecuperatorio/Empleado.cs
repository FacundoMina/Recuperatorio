using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRecuperatorio
{
    public class Empleado
    {
        public string nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public float SueldoFinal { get; set; }
        public string Tipo { get; set; }

        public float sueldo { get; set; }
        

        public Empleado(string nombre, int dni, string apellido)
        {
            this.nombre = nombre;
            this.DNI = dni;
            this.Apellido = apellido;

        }

    }
}
