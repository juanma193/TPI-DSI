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

        public OpcionValidacion(string descripcion, bool correcta)
        {
            this.descripcion = descripcion;
            this.correcta = correcta;
        }

        internal string getDescripcion()
        {
            return descripcion;
        }

        internal bool esCorrecta()
        {
            return correcta;
        }
    }
}
