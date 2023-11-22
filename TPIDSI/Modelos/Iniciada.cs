using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class Iniciada : Estado
    {
        public override bool esEnCurso()
        {
            return false;
        }
        public EnCurso procesar(Llamada llamada,DateTime fecha)
        {
            EnCurso enCurso = crearProximoEstado();
            CambioEstado nuevo = crearCambioEstado(enCurso,fecha);
            llamada.cambiosEstados.Add(nuevo);
            return enCurso;
        }

        private EnCurso crearProximoEstado()
        {
            return new EnCurso();
        }

        public override bool esFinalizada()
        {
            return false;
        }
    }
}
