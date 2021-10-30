using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Interfaces
{
    interface IEmpleados
    {

        public string nombre { get; set; }
        public decimal salario { get; set; }

        public decimal calcularSalario()
        {
            return 0;
        }

        public decimal calcularSalario(decimal comision)
        {
            return 0;
        }

    }
}
