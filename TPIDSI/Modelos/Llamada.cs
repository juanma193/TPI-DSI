    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class Llamada
    {
        string descripcionOperador { get; set; }
        string detalleAccionRequerida { get; set; }
        int duracion { get; set; }
        bool encuestaEnviada { get; set; }
        string observacionAuditor { get; set; }
        Cliente cliente { get; set; }
        Accion accionRequerida { get; set; }
        OpcionLlamada opcionSeleccionada { get; set; }
        SubOpcionLlamada subOpcionSeleccionada { get; set; }

        public Llamada(string descripcionOp, string detalleAccion, int duracion, bool encuesta, string observacion, Cliente cliente,Accion accion, OpcionLlamada opcion, SubOpcionLlamada subOpcionSeleccionada)
        {
            this.descripcionOperador = descripcionOp;
            this.detalleAccionRequerida = detalleAccion;
            this.duracion = duracion;
            this.encuestaEnviada = encuesta;
            this.observacionAuditor = observacion;
            this.cliente = cliente;
            this.accionRequerida = accion;
            this.opcionSeleccionada = opcion;
            this.subOpcionSeleccionada = subOpcionSeleccionada;
        }
    }
}
