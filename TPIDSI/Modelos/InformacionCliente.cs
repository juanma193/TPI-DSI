using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class InformacionCliente
    {
        string datoAValidar { get; set; }
        public InformacionCliente(string dato)
        {
            this.datoAValidar = dato;
        }
    }
}
