using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recuperatorioparcial2;

namespace clasesparcial2
{

    public class EmpleadoAdministrativo : Empleado
    {
        public int Antiguedad { get; set; }

        public EmpleadoAdministrativo(string nombre, decimal sueldoBase, int antiguedad)
            : base(nombre, sueldoBase)
        {
            Antiguedad = antiguedad;
        }

        
        public override double CalcularSueldoFinal()
        {
            return SueldoBase + (Antiguedad * 1000);
        }
    }
}
