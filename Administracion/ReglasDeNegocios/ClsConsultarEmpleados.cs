using ReglasDeNegocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.ReglasDeNegocios
{
    static class ClsConsultarEmpleados 
    {

        public static ArrayList Empleado = new ArrayList();

        public static void grabarEmpleado(ClsEmpleados empleado)
        {
            Empleado.Add(empleado);
        }

        public static void listarEmpleado()
        {
            foreach (ClsEmpleados obj in Empleado)
                Console.WriteLine($"El salario del empleado {Empleado.IndexOf(obj)} - {obj.nombre} es de ${ obj.salario}");
        }


    }
}
