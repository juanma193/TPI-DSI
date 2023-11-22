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
        //Creacion de los atributos del gestor
        private static Llamada actualLlamada { get; set; }
        private static string nombreCliente { get; set; }
        private static string nombreCategoria { get; set; }
        private static string nombreOpcion { get; set; }
        private static string nombreSubOpcion { get; set; }
        private static OpcionLlamada opcionSeleccionada { get; set; }
        private static SubOpcionLlamada subOpcionLlamada { get; set; }
        private static List<Validacion> validaciones { get; set;}
        private static PantallaRespuestaOperador pantalla { get; set; }
        private static string descripcionAccionSeleccionada { get; set;}
        private static List<string> descripcionOpciones { get; set; }
        private static int indiceValidacion = 0;
        private static bool validacionesCorrectas = true;
        private static List<Accion> acciones = listaAcciones;
        private static string descripcionOperador { get; set; }
        private static EnCurso estadoEnCurso { get; set; } = null;

        //Metodo para obtener la llamada actual
        public static void obtenerLlamadaActual(Llamada llamada)
        {
            actualLlamada = llamada;
        }

        //Obtenemos la pantalla del operador junto con los datos necesarios
        public void seleccionComunicarseConOperador(Llamada llamadaIniciada, CategoriaLlamada categoriaLlamada, OpcionLlamada opcionLlamada, SubOpcionLlamada subOpcion, PantallaRespuestaOperador pantallaRespuestaOperador)
        {
            pantalla = pantallaRespuestaOperador;
            subOpcionLlamada = subOpcion;
            opcionSeleccionada = opcionLlamada;
            obtenerLlamadaActual(llamadaIniciada);
            estadoEnCurso = actualizarEstadoLlamada();
            buscarDatosLlamada(categoriaLlamada, opcionLlamada, subOpcion);
            buscarVlaidacionesDeSubOpcion(subOpcion);
            pantalla.habilitarPantalla();
            pantalla.mostrarDatosLlamada(nombreCategoria, nombreCliente, nombreOpcion, nombreSubOpcion);
            realizarValidaciones();

        }


        //Se valida la respuesta del operador
        internal static void tomarRespuestaOpcion(string descripcionSeleccionada)
        {
            if (validaciones[indiceValidacion].validarOpcion(descripcionSeleccionada))
            {
                indiceValidacion++;
            }
            else
            {
                pantalla.OpcionIncorrecta();
            }
        }

        //Se guarda la descripcion escrita por el operador
        internal void tomarDescripcionRespuesta(string text)
        {
            descripcionOperador = text;
            List<string> descripcionesAccion = buscarDescripcionAccion();
            pantalla.mostrarAcciones(descripcionesAccion);
        }

        //Get la descripcion de las acciones
        private List<string> buscarDescripcionAccion()
        {
            List<string> retorno = new List<string>();
            foreach (Accion a in acciones)
            {
                retorno.Add(a.getDescripcion());
            }
            return retorno;
        }

        public void realizarValidaciones()
        {
            if (indiceValidacion < validaciones.Count)
            {
                Validacion v = validaciones[indiceValidacion];
                string mensajeVal = v.getMensajeValidacion();
                pantalla.mostrarMensajeValidacion(mensajeVal);
                descripcionOpciones = v.getDescripcionOpciones();
                pantalla.mostrarOpciones(descripcionOpciones);
                
            }
            else
            {
                if (validacionesCorrectas)
                {
                    pantalla.solicitarDescripcionRespuesta();

                }
            }
        }

        internal void tomarConfirmacion()
        {
            registrarAccionRequerida();
        }

        internal void tomarAccionSeleccionada(string descripcionAccion)
        {
            descripcionAccionSeleccionada = descripcionAccion;
        }

        private void registrarAccionRequerida()
        {
            //llamar CU 28. Registrar Accion Requerida
            pantalla.informarSituacion();
            finalizarLlamada();
        }

        public void finalizarLlamada()
        {
            actualLlamada.setOpcion(opcionSeleccionada);
            actualLlamada.setSubOpcion(subOpcionLlamada);
            actualLlamada.setDescripcionOperador(descripcionOperador);
            DateTime dateTime = DateTime.Now;
            DateTime fechaHoraInicio = buscarFechaHoraInicio();
            double duracion = calcularDuracion(dateTime, fechaHoraInicio);
            actualLlamada.setDuracion(duracion);
            actualLlamada.finalizar(dateTime, estadoEnCurso);
            int stop = 0;
            //finCu();

        }

        private Estado buscarEstadoFinalizada()
        {
            foreach (Estado e in estados)
            {
                if (e.esFinalizada())
                {
                    return e;
                }
            }
            return null;
        }

        private double calcularDuracion(DateTime dateTime, DateTime fechaHoraInicio)
        {
            TimeSpan ts = dateTime - fechaHoraInicio;
            return ts.TotalMinutes;
        }

        private DateTime buscarFechaHoraInicio()
        {
            return actualLlamada.obtenerFechaHoraInicio();
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

        private static EnCurso actualizarEstadoLlamada()
        {
            DateTime dateTime = DateTime.Now;
            return actualLlamada.procesar(dateTime);
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
    }
}
