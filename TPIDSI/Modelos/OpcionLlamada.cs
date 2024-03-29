﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class OpcionLlamada
    {
        string audioMensajeLlamada { get; set; }
        string mensajeSubOpciones { get; set; }
        string nombre { get; set; }
        int nroOrden { get; set; }
        public List<Validacion> validacionesRequeridas { get; set; }
        public List<SubOpcionLlamada> subOpcionLlamada { get; set; }
        public OpcionLlamada(string audio, string mensaje, string nombre, int nroOrden, List<Validacion> validaciones, List<SubOpcionLlamada> subOpcion)
        {
            this.audioMensajeLlamada = audio;
            this.mensajeSubOpciones = mensaje;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.validacionesRequeridas = validaciones;
            this.subOpcionLlamada = subOpcion;
        }

        internal string getNombre()
        {
            return this.nombre;
        }
    }
}
