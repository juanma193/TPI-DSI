using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class SubOpcionLlamada
    {
        string nombre { get; set; }
        int nroOrden { get; set; }
        List<Validacion> validacionRequerida { get; set; }
        public SubOpcionLlamada(string nombre, int nroOrden,List<Validacion> validaciones)
        {
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.validacionRequerida = validaciones;
        }
    }
}
