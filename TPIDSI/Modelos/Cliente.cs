using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class Cliente
    {
        long dni { get; set; }
        string nombreCompleto { get; set; }
        long nroCelular { get; set; }
        List<InformacionCliente> info { get; set; }
        public Cliente(long dni, string nombre, long celular, List<InformacionCliente> info) 
        {
            this.dni = dni;
            this.nombreCompleto = nombre;
            this.nroCelular = celular;
            this.info = info;
        }

        internal string getNombre()
        {
            return nombreCompleto;
        }
    }
}
