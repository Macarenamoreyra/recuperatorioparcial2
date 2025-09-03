using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesparcial2
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Dni {  get; set; }
        public int Sueldobase { get; set; } 
        public double ValorHoraExtra { get; set; }
        public int HorasExtras { get; set; }
        public double Descuentos { get; set; }
        public Empleado (string Nombre, string Dni, int Sueldobase, Double ValorHoraExtra, int HorasExtras, double Descuentos)
        {
            this.Nombre = Nombre;
            this.Dni = Dni; 
            this.Sueldobase = Sueldobase;
        }
        public double CalcularSueldoFinal()
        {
            double pagoHorasExtras = HorasExtras * ValorHoraExtra;
            double sueldoFinal = Sueldobase + pagoHorasExtras - Descuentos;
            return sueldoFinal;
        }

    }
}