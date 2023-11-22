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

        private void finalizar(DateTime fecha, Llamada actual)
        {
            throw new NotImplementedException();
        }

        private Estado crearProximoEstado()
        {
            throw new NotImplementedException();
        }

        private EnCurso procesar(DateTime fecha, Llamada actual)
        {
            throw new NotImplementedException();
        }

        
    }
}
