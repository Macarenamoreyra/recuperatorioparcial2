using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clasesparcial2;

namespace clasesparcial2
{
    public class Gestiondeempleados
    {
        public List<Empleado> Empleado { get; set; }
        public Empleado BuscarEmpleadoPorDni(string dni)
        {
            foreach (var empleado in Empleado)
            {
                if (empleado.Dni == dni)  
                {
                    return empleado;      
                }
            }

            return null; 
        }
        public Gestiondeempleados ()
        {

        }
    }
