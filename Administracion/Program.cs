using Administracion.ReglasDeNegocios;
using ReglasDeNegocios;
using System;

namespace Administracion
{
    class Program
    {
        static void Main(string[] args)
        {


            // ESTRUCTURA DEL PROGRAMA -> IEMPLEADO TIENE LA ESTRUCTURA QUE SE IMPLEMENTA EN LA CLASE BASE (ABSTRACTA) EMPLEADOS DE LA CUAL HEREDAN EMPLEADO Y VENDEDOR.
            //ADEMAS UTILIZO UNA CLASE ESTATICA PARA GUARDAR LOS EMPLEADOS Y LUEGO LISTARLOS

            void mensajePorConsola(string mensaje)
            {
                Console.WriteLine(mensaje);
            }

            mensajePorConsola("Bienvenido al sistema de administración");
            mensajePorConsola("Debe registrar 3 empleados");

            int opcionIngresada = 0;

            for (int i = 0; i < 3; i++)
            {

                try
                {
                    mensajePorConsola("Si desea registrar un empleado presione 1 si desea cargar un vendedor presione 2");
                    opcionIngresada = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    mensajePorConsola("Se produjo un error. " + ex.Message);
                    Environment.Exit(0);
                }


                switch (opcionIngresada)
                {

                    case 1:
                        {

                            try
                            {
                                ClsEmpleado ObjEmpleado = new ClsEmpleado();

                                mensajePorConsola("Ingrese el nombre del Empleado");
                                ObjEmpleado.nombre = Console.ReadLine().ToUpper();

                                mensajePorConsola("Ingrese el salario del Empleado");
                                ObjEmpleado.salario = decimal.Parse(Console.ReadLine());

                                mensajePorConsola($"El empleado {ObjEmpleado.nombre.ToUpper()} se registro con éxito");

                                ClsConsultarEmpleados.grabarEmpleado(ObjEmpleado);

                            }
                            catch (Exception ex)
                            {
                                mensajePorConsola("Se produjo un error. " + ex.Message);
                                Environment.Exit(0);
                            }

                        }
                        break;

                    case 2:
                        {

                            try
                            {
                                ClsVendedor ObjVendedor = new ClsVendedor();

                                mensajePorConsola("Ingrese el nombre del Vendedor");
                                ObjVendedor.nombre = Console.ReadLine().ToUpper();

                                mensajePorConsola("Ingrese el salario del Vendedor");
                                ObjVendedor.salario = decimal.Parse(Console.ReadLine());

                                mensajePorConsola("Ingrese la comisión del Vendedor");
                                ObjVendedor.comision = decimal.Parse(Console.ReadLine());

                                ObjVendedor.salario = ObjVendedor.calcularSalario(ObjVendedor.comision);

                                mensajePorConsola($"El vendedor {ObjVendedor.nombre.ToUpper()} se registro con éxito");

                                ClsConsultarEmpleados.grabarEmpleado(ObjVendedor);

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
                        }
                        break;

                }

            }

            mensajePorConsola("¿Desea listar los empleados cargados en el sistema? Presione 1 para listar o 2 para salir");

            if (int.Parse(Console.ReadLine()) == 1)
            {
                ClsConsultarEmpleados.listarEmpleado();
            }

        }
    }
}
