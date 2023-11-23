using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class OpcionValidacion
    {
        private bool correcta { get; set; }
        private string descripcion { get; set; }
        public int idValidacion { get; set; }

        public OpcionValidacion(string descripcion, bool correcta, int id)
        {
            this.descripcion = descripcion;
            this.correcta = correcta;
            this.idValidacion = id;
        }

        internal string getDescripcion()
        {
            return descripcion;
        }

        internal bool esCorrecta()
        {
            return correcta;
        }

        internal bool esTuDescripcion(string descripcionSeleccionada)
        {
            return descripcion == descripcionSeleccionada;
        }
    }
}
