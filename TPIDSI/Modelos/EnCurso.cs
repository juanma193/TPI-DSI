using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class EnCurso : Estado
    {

        public void finalizar(Llamada llamada, DateTime fecha)
        {
            Finalizada enCurso = crearProximoEstado();
            CambioEstado nuevo = crearCambioEstado(enCurso, fecha);
            llamada.cambiosEstados.Add(nuevo);
        }
        private Finalizada crearProximoEstado()
        {
            return new Finalizada();
        }
    }
}
