using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class Validacion
    {
        string audioMensajeValidacion { get;set; }
        string nombre { get; set; }
        int nroOrden { get; set; }
        public Validacion(string audio, string nombre, int nroOrden) 
        {
            this.audioMensajeValidacion = audio;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
        }
    }
}
