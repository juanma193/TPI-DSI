using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPIDSI.Modelos;
using static TPIDSI.BaseDeDatos;

namespace TPIDSI
{
    public class GestorLlamada
    {
        public Llamada obtenerLlamadaActual()
        {
            Llamada llamada = llamadaIniciada;
            return llamada;
        }

    }
}
