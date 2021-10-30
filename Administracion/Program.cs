using ReglasDeNegocios;
using System;

namespace Administracion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de administración");
            Console.WriteLine("Ingrese 1 para cargar el salario de un empleado o 2 para el salario de un vendedor");

            void mensajePorConsola(string mensaje)
            {
                Console.WriteLine(mensaje);
            }

            int opcionIngresada = 0;

            try
            {
                opcionIngresada = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                mensajePorConsola("Se produjo un error. " + ex.Message);
                Environment.Exit(0);
            }
                                   

            switch (opcionIngresada)
            {

                case 1: {

                        try
                        {
                            ClsEmpleado ObjEmpleado = new ClsEmpleado();

                            mensajePorConsola("Ingrese el nombre del Empleado");
                            ObjEmpleado.nombre = Console.ReadLine();

                            mensajePorConsola("Ingrese el salario del Empleado");
                            ObjEmpleado.salario = decimal.Parse(Console.ReadLine());

                            mensajePorConsola("El salario del empleado " + ObjEmpleado.nombre.ToUpper() + " es $ " + ObjEmpleado.calcularSalario());
                        }
                        catch (Exception ex)
                        {
                            mensajePorConsola("Se produjo un error. " + ex.Message);
                            Environment.Exit(0);
                        }



                    }
                        break;

                case 2: {

                        try
                        {
                            ClsVendedor ObjVendedor = new ClsVendedor();

                            mensajePorConsola("Ingrese el nombre del Vendedor");
                            ObjVendedor.nombre = Console.ReadLine();

                            mensajePorConsola("Ingrese el salario del Vendedor");
                            ObjVendedor.salario = decimal.Parse(Console.ReadLine());

                            mensajePorConsola("Ingrese el salario del Vendedor");
                            ObjVendedor.comision = decimal.Parse(Console.ReadLine());

                            mensajePorConsola("El salario del vendedor " + ObjVendedor.nombre.ToUpper() + " es $ " + ObjVendedor.calcularSalario(ObjVendedor.comision));
                        }
                        catch (Exception ex)
                        {
                            mensajePorConsola("Se produjo un error. " + ex.Message);
                            Environment.Exit(0);
                        }

                    }
                        break;

                default:
                    {
                        mensajePorConsola("La opción ingresada no es válida.");
                    } break;

            }

        }
    }
}
