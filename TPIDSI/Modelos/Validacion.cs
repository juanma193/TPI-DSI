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
        List<OpcionValidacion> opcionesVlaidacion { get; set; }
        public Validacion(string audio, string nombre, int nroOrden, List<OpcionValidacion> opcionesVlaidacion)
        {
            this.audioMensajeValidacion = audio;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.opcionesVlaidacion = opcionesVlaidacion;
        }

        internal string getMensajeValidacion()
        {
            return audioMensajeValidacion;
        }

        internal List<string> getDescripcionOpciones()
        {
            List<string> descripcionOpciones = new List<string>();
            foreach(OpcionValidacion opcion in BaseDeDatos.validacionList) { descripcionOpciones.Add(opcion.getDescripcion()); }
            return descripcionOpciones;
        }

        internal bool esOpcionCorrecta(string descripcionSeleccionada)
        {
            foreach (OpcionValidacion opcion in opcionesVlaidacion)
            {
                if (opcion.getDescripcion().Equals(descripcionSeleccionada))
                {
                    return opcion.esCorrecta();
                }
            }
            return false;
        }
    }
}
