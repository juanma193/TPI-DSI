using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class CambioEstado
    {
        DateTime fechaHoraInicio { get; set; }
        Estado estado { get; set; }
        public CambioEstado(DateTime fechaInicio, Estado estado) 
        {
            this.fechaHoraInicio = fechaInicio;
            this.estado = estado;
        }   
    }
}
