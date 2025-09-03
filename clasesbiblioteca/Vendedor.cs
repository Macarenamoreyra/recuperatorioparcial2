using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using recuperatorioparcial2;

namespace clasesparcial2
{
    public class Empleadovendedor:Empleado
    {
       public int Montoventasmensuales {  get; set; }
        public Empleadovendedor(string Nombre, string Dni, int Sueldobase, int Montoventasmensuales) : base(Nombre, Dni, Sueldobase)
        {
            this.Montoventasmensuales = Montoventasmensuales;
        }
        

    }
}
