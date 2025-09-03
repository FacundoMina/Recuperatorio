using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClasesRecuperatorio;

namespace Recuperatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> ListaEmpleados = new List<Empleado>();
            
            do
            {
                Console.WriteLine("======================================");
                Console.WriteLine("\tBienvenido al Menu");
                Console.WriteLine("======================================");
                Console.WriteLine();
                Console.WriteLine("1- Registrar Empleado");
                Console.WriteLine("2- Mostrar Informacion Empleado ");
                Console.WriteLine("3- Mostrar todos los Empleados y Estadisticas");
                Console.WriteLine("4- Salir");
                Console.WriteLine();
                Console.Write("Ingrese una opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                if (opcion == 1)
                {
                    Console.WriteLine("1- Empleado Administrativo");
                    Console.WriteLine("2- Empleado Vendedor");
                    Console.Write("Ingrese el tipo de empleado a registrar: ");
                    int tipoEmpleado = int.Parse(Console.ReadLine());
                    if (tipoEmpleado == 1)
                    {
                        Console.Write("Ingrese el nombre del empleado: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el apellido del empleado: ");
                        string apellido = Console.ReadLine();
                        Console.Write("Ingrese el DNI del empleado: ");
                        int dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Tipo : Administrativo");
                        string tipo = Console.ReadLine();
                        Console.Write("Ingrese el sueldo base del empleado: ");
                        float sueldoBase = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese la antiguedad del empleado (en años): ");
                        int antiguedad = int.Parse(Console.ReadLine());
                        EmpleadoAdministrativo empAdmin = new EmpleadoAdministrativo(nombre, dni, apellido, tipo);
                        empAdmin.sueldo = sueldoBase;
                        empAdmin.Antiguedad = antiguedad;
                        ListaEmpleados.Add(empAdmin);
                        Console.WriteLine("Empleado Administrativo registrado exitosamente.");
                        
                    }
                    else if (tipoEmpleado == 2)
                    {
                        Console.Write("Ingrese el nombre del empleado: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el apellido del empleado: ");
                        string apellido = Console.ReadLine();
                        Console.Write("Ingrese el DNI del empleado: ");
                        int dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Tipo : Vendedor");
                        string tipo = Console.ReadLine();
                        Console.Write("Ingrese el sueldo base del empleado: ");
                        float sueldoBase = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el monto de ventas mensuales del empleado: ");
                        int montoVentas = int.Parse(Console.ReadLine());
                        EmpleadoVendedor empVendedor = new EmpleadoVendedor(nombre, dni, apellido, tipo);
                        empVendedor.sueldo = sueldoBase;
                        empVendedor.MontoVentasMensuales = montoVentas;
                        ListaEmpleados.Add(empVendedor);
                        Console.WriteLine("Empleado Vendedor registrado exitosamente.");
                        
                    }
                    else
                    {
                        Console.WriteLine("Tipo de empleado no valido.");
                        
                    }



                }
                if (opcion == 2)
                {
                    Console.Write("Ingrese el DNI del empleado a buscar: ");
                    int dniBuscar = int.Parse(Console.ReadLine());
                    int SueldoFinalAdmin = 0;
                    int SueldoFinalVendedor = 0;

                    foreach (Empleado empleado in ListaEmpleados)
                    {
                        if (empleado.DNI == dniBuscar)
                        {
                            if (empleado is EmpleadoAdministrativo)
                            {
                                SueldoFinalAdmin = (int)CalcularSueldoFinalAdmin(empleado.sueldo, ((EmpleadoAdministrativo)empleado).Antiguedad);
                                Console.WriteLine($"Nombre: {empleado.nombre}, Apellido: {empleado.Apellido}, SueldoFinal: {SueldoFinalAdmin}, TipoEmpleado:{empleado.Tipo}");
                            }
                            else if (empleado is EmpleadoVendedor)
                            {
                                SueldoFinalVendedor = (int)CalcularSueldoFinalVendedor(empleado.sueldo, ((EmpleadoVendedor)empleado).MontoVentasMensuales);
                                Console.WriteLine($"Nombre: {empleado.nombre}, Apellido: {empleado.Apellido}, SueldoFinal: {SueldoFinalVendedor}, TipoEmpleado: {empleado.Tipo}");
                            }


                        }
                    }

                }

                if (opcion == 3)
                {
                    int CantSueldos = 0;
                    foreach (Empleado empleado in ListaEmpleados)
                    {
                        Console.WriteLine($"Nombre:{empleado.nombre}, Apellido:{empleado.Apellido}, Tipo:{empleado.Tipo}");
                        CantSueldos++;
                    }
                    ListaEmpleados.Count();
                    Console.WriteLine($"Total de empleados registrados: {ListaEmpleados.Count()}");
                    Console.WriteLine($"Total de sueldos a pagar: {CantSueldos}");


                }
                if (opcion == 4)
                {
                    break;
                }



            } while (true);

            float CalcularSueldoFinalAdmin(float sueldobase, int antiguedad)
            {
                float SueldoFinal = sueldobase + antiguedad * 1000;
                return SueldoFinal;
            }
            float CalcularSueldoFinalVendedor(float sueldobase, int montoVentasMensuales)
            {
                float SueldoFinal = (float)(sueldobase + montoVentasMensuales * 0.10);
                return SueldoFinal;
            }
        }
    }
        
    
}
