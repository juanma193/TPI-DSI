﻿    using System;
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
        double duracion { get; set; }
        bool encuestaEnviada { get; set; }
        string observacionAuditor { get; set; }
        Cliente cliente { get; set; }
        Accion accionRequerida { get; set; }
        OpcionLlamada opcionSeleccionada { get; set; }
        SubOpcionLlamada subOpcionSeleccionada { get; set; }
        List<CambioEstado> cambiosEstados { get; set; }

        public Llamada(string descripcionOp, string detalleAccion, double duracion, bool encuesta, string observacion, Cliente cliente,Accion accion, OpcionLlamada opcion, SubOpcionLlamada subOpcionSeleccionada, List<CambioEstado> cambiosEstados)
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
            this.cambiosEstados = cambiosEstados;
        }

        internal string getNombreClienteDeLlamada()
        {
            return cliente.getNombre();
        }

        internal void actualizarEstado(Estado estado, DateTime dateTime)
        {
            cambiosEstados.Add(new CambioEstado(dateTime, estado));
        }

        internal void setOpcion(OpcionLlamada opcionLlamada)
        {
            opcionSeleccionada = opcionLlamada;
        }

        internal void setSubOpcion(SubOpcionLlamada subOpcionLlamada)
        {
            subOpcionSeleccionada = subOpcionLlamada;
        }

        internal void setDescripcionOperador(string descripcionOperador)
        {
            this.descripcionOperador = descripcionOperador;
        }

        internal void setDuracion(double duracion)
        {
            this.duracion = duracion;
        }

        internal DateTime obtenerFechaHoraInicio()
        {
            DateTime fecha = DateTime.Now;
            foreach (CambioEstado ce in cambiosEstados)
            {
                if(ce.getFechaHoraInicio() < fecha)
                {
                    fecha = ce.getFechaHoraInicio();
                }
            }
            return fecha;
        }
    }
}
