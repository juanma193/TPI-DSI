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
    }
}
