using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeNegocios
{
    class ClsVendedor : ClsPersona 
    {

        private decimal _comision;
        public decimal comision
        {
            get { return _comision; }
            set { _comision = value; }
        }

        //SOBREESCRIBO EL METODO DE LA CLASE BASE
        public override decimal calcularSalario(decimal comision)
        {
            return this.salario + comision;
        }

    }
}
