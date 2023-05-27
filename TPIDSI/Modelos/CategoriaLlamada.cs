using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class CategoriaLlamada
    {
        string audioMensajeOpciones {  get; set; }
        string mensajeOpciones { get; set; }
        string nombre { get; set; }
        int nroOrden { get; set; }
        List<OpcionLlamada> opcion { get; set; }
        public CategoriaLlamada(string audioMensajeOpciones, string mensajeOpciones, string nombre, int nroOrden, List<OpcionLlamada> opcion)
        {
            this.audioMensajeOpciones = audioMensajeOpciones;
            this.mensajeOpciones = mensajeOpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.opcion = opcion;
        }

        internal string getNombre()
        {
            return this.nombre;
        }
    }
}
