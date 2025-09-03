using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using clasesparcial2;

namespace recuperatorioparcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> Listaempleados = new List<Empleado>();
            while (true)
            {
                Console.WriteLine( " Menú biblioteca");
                Console.WriteLine("Opcion 1 : Registrar empleado");
                Console.WriteLine("Opcion 3 : Mostrar Informacion de un empleado");
                Console.WriteLine("Opcion 4 : Mostrar todos los empleados y estadisticas");
                Console.WriteLine("Opcion 5 : Salir");
                
                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    Console.WriteLine("Es usted 1)Vendedor o 2)Administrativo: Ingrese opcion '1'  '2' o 'Ninguna'");
                    string Respuesta = (Console.ReadLine());
                    if (Respuesta == "1")
                    {
                        Console.WriteLine("Ingrese Dni: ");
                        string dni = Console.ReadLine();
                        Gestiondeempleados gestor = new Gestiondeempleados();

                       
                        Empleado empleado = gestor.BuscarEmpleadoPorDni(dni);

                        if (empleado != null)
                        {
                            Console.WriteLine("Ingrese Nombre y apellido: ");
                            string nombre = Console.ReadLine();

                            Console.WriteLine("Ingrese sueldo: ");
                            int sueldo = int.Parse(Console.ReadLine());

                           
                        }
                        else
                        {
                            Console.WriteLine("Empleado no encontrado.");
                        }

                        Console.WriteLine("ingrese Nombre: ");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su sueldo base: ");
                        int SueldoBase = int.Parse(Console.ReadLine());
                        double ValorHoraextra = 4500;
                        Console.WriteLine("Ingrese la cantidad de horas extras: ");
                        int HorasExtras = int.Parse(Console.ReadLine());    
                        double Descuentos = 10%
                        
                        Empleado empleado = new Empleado(Nombre, dni, SueldoBase, ValorHoraextra, HorasExtras, Descuentos);
                        Listaempleados.Add(empleado);

                    }
                    else
                    {
                        Console.WriteLine("No puede ingresar");
                        break;
                    }
                } 
                if(opcion == "2")
                {
                    Console.WriteLine("Ingrese Dni: ");
                    string dni = Console.ReadLine();
                    Empleado empleado = gestor.BuscarEmpleadoPorDni(dni);
                    Console.WriteLine($"Empleado encontrado: {empleado.Nombre}, DNI: {empleado.Dni}, Sueldo ingresado: {sueldo}");
                }
                if (opcion == "3")
                {

                    Console.WriteLine(Listaempleados);
                    //no llego con el tiempo

                }
            }
        }
    }
}
