using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class Estado
    {
        string nombre {  get; set; }
        public Estado(string nombre)
        {
            this.nombre = nombre;
        }
        public bool esEnCurso()
        {
            return nombre == "En curso";
        }

        internal bool esFinalizada()
        {
            return nombre == "Finalizada";
        }
    }
}
