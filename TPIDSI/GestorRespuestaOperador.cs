using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPIDSI.Modelos;
using static TPIDSI.BaseDeDatos;

namespace TPIDSI
{
    public class GestorRespuestaOperador
    {
        private static Llamada actualLlamada { get; set; }
        private static Estado estadoEnCurso { get; set; }
        private static string nombreCliente { get; set; }
        private static string nombreCategoria { get; set; }
        private static string nombreOpcion { get; set; }
        private static string nombreSubOpcion { get; set; }
        private static List<Validacion> validaciones { get; set;}
        private static PantallaRespuestaOperador pantalla { get; set; }
        private static List<string> descripcionOpciones { get; set; }
        private static bool validacionesCorrectas = true;


        public static void obtenerLlamadaActual(Llamada llamada)
        {
            actualLlamada = llamada;
        }

        internal static void seleccionComunicarseConOperador(Llamada llamadaIniciada, CategoriaLlamada categoriaLlamada, OpcionLlamada opcionLlamada, SubOpcionLlamada subOpcion, PantallaRespuestaOperador pantallaRespuestaOperador)
        {
            pantalla = pantallaRespuestaOperador;
            obtenerLlamadaActual(llamadaIniciada);
            estadoEnCurso = buscarEstadoEnCurso();
            actualizarEstadoLlamada();
            buscarDatosLlamada(categoriaLlamada, opcionLlamada, subOpcion);
            buscarVlaidacionesDeSubOpcion(subOpcion);
            pantalla.habilitarPantalla();
            pantalla.mostrarDatosLlamada(nombreCategoria, nombreCliente, nombreOpcion, nombreSubOpcion);
            realizarValidaciones();

        }

        internal static void tomarRespuesta(string descripcionSeleccionada)
        {
            if ( val.esOpcionCorrecta(descripcionSeleccionada))
            {
                
            }
            else
            {
                validacionesCorrectas = false;
            }
        }

        public static void realizarValidaciones()
        {
            foreach (Validacion v in validaciones)
            {
                
                string mensajeVal = v.getMensajeValidacion();
                pantalla.mostrarMensajeValidacion(mensajeVal);
                descripcionOpciones = v.getDescripcionOpciones();
                pantalla.mostrarOpciones(descripcionOpciones);
            }
        }

        private static void buscarVlaidacionesDeSubOpcion(SubOpcionLlamada subopcion)
        {
            validaciones = subopcion.getValidaciones();
        }

        private static void buscarDatosLlamada(CategoriaLlamada categoriaLlamada, OpcionLlamada opcionLlamada, SubOpcionLlamada subOpcion)
        {
            nombreCliente = actualLlamada.getNombreClienteDeLlamada();
            nombreCategoria = categoriaLlamada.getNombre();
            nombreOpcion = opcionLlamada.getNombre();
            nombreSubOpcion = subOpcion.getNombre();

        }

        private static void actualizarEstadoLlamada()
        {
            DateTime dateTime = DateTime.Now;
            actualLlamada.actualizarEstado(estadoEnCurso, dateTime);
        }

        private static Estado buscarEstadoEnCurso()
        {
            foreach (Estado e in estados)
            {
                if (e.esEnCurso())
                {
                    return e;
                }
            }
            return null;
        }
        private static Validacion val { get; set; }
    }
}
