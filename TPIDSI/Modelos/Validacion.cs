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
        List<OpcionValidacion> opcionesValidacion { get; set; }
        public Validacion(string audio, string nombre, int nroOrden, List<OpcionValidacion> opcionesValidacion)
        {
            this.audioMensajeValidacion = audio;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.opcionesValidacion = opcionesValidacion;
        }

        internal string getMensajeValidacion()
        {
            return audioMensajeValidacion;
        }

        internal List<string> getDescripcionOpciones()
        {
            List<string> descripcionOpciones = new List<string>();
            foreach(OpcionValidacion opcion in opcionesValidacion) { descripcionOpciones.Add(opcion.getDescripcion()); }
            return descripcionOpciones;
        }

        internal bool validarOpcion(string descripcionSeleccionada)
        {
            foreach (OpcionValidacion opcion in opcionesValidacion)
            {
                if (opcion.esTuDescripcion(descripcionSeleccionada))
                {
                    return opcion.esCorrecta();
                }
            }
            return false;
        }
    }
}
