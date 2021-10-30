using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeNegocios
{
    abstract class ClsPersona
    {

        private string _nombre;
        private decimal _salario;

        public string nombre { 
            get {return _nombre; } 
            set { _nombre = value;}
        }

        public decimal salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        public virtual decimal calcularSalario()
        {
            return 0;
        }

        //METODO CON SOBRE CARGA
        public virtual decimal calcularSalario(decimal comision)
        {
            return 0;
        }

    }
}
