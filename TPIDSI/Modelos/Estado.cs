using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public abstract class Estado
    { 


        public CambioEstado crearCambioEstado(Estado e, DateTime fecha)
        {
            return new CambioEstado(fecha, e);
        }

        public abstract bool esEnCurso();


        public abstract bool esFinalizada();
        
    }
}
