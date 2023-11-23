using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class Accion
    {
        public string descripcion { get; set; }
        public Accion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public Accion() { }

        internal string getDescripcion()
        {
            return descripcion;
        }
    }
}
