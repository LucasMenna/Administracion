using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeNegocios
{
    class ClsEmpleado : ClsPersona
    {

        //SOBREESCRIBO EL METODO DE LA CLASE BASE
        public override decimal calcularSalario()
        {
            return salario;
        }

    }
}
