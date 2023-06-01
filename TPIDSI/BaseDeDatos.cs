using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPIDSI.Modelos;

namespace TPIDSI
{
    public class BaseDeDatos
    {
        //Creamos los estados
        public static Estado estado1 = new Estado("Iniciada");
        public static Estado estado2 = new Estado("En curso");
        public static Estado estado3 = new Estado("Finalizada");

        public static Estado[] estados = { estado1, estado2, estado3 };

        //Creamos accion
        public static Accion accion1 = new Accion("Dar de baja a la tarjeta");
        public static Accion accion2 = new Accion("Pedir nueva tarjeta");
        public static Accion accion3 = new Accion("Pausar acciones de la tarjeta");
        public static Accion accion4 = new Accion("Otros motivos");
        public static List<Accion> listaAcciones = new List<Accion>() { accion1, accion2, accion3, accion4};


        //Creamos cambios de estados
        public static CambioEstado cambio1 = new CambioEstado(new DateTime(2016, 03, 07), estado1);
        public static List<CambioEstado> cambiosEstados = new List<CambioEstado> { cambio1 };

        //Creacion OpcionesValidacion
        public static OpcionValidacion opcionValidacion1 = new OpcionValidacion("opcion 1", true);
        public static OpcionValidacion opcionValidacion2 = new OpcionValidacion("opcion 2", false);
        public static OpcionValidacion opcionValidacion3 = new OpcionValidacion("opcion 3", false);
        public static List<OpcionValidacion> validacionList = new List<OpcionValidacion>() { opcionValidacion1, opcionValidacion2, opcionValidacion3 };

        //Creamos validaciones
        public static Validacion validacion1 = new Validacion("validacion 1","hola", 1, validacionList);
        public static Validacion validacion2 = new Validacion("validacion 2","estamos", 2, validacionList);
        public static Validacion validacion3 = new Validacion("validacion 3","listos", 3, validacionList);
        public static List<Validacion> listaValidacion = new List<Validacion>() { validacion1, validacion2, validacion3 };

        //Creamos informacion del cliente
        public static InformacionCliente info1 = new InformacionCliente("Hola",validacion1);
        public static InformacionCliente info2 = new InformacionCliente("Chau",validacion2);

        //Creamos  la lista de informacion del cliente
        public static List<InformacionCliente> listaInformacion = new List<InformacionCliente>() { info1, info2 };



        //Creacion del cliente
        public static Cliente cliente1 = new Cliente(45690486, "Hassan", 3512012116, listaInformacion);

        //Creacion SubOpciones
        public static SubOpcionLlamada subOpcion1 = new SubOpcionLlamada("Atencion al cliente", 1,listaValidacion);
        public static SubOpcionLlamada subOpcion2 = new SubOpcionLlamada("subOpcion 2", 2, listaValidacion);
        public static List<SubOpcionLlamada> subOpciones = new List<SubOpcionLlamada>() { subOpcion1, subOpcion2 };

        //Creacion opcionLlamada
        public static OpcionLlamada opcionLlamada = new OpcionLlamada("Hola", "como estas", "Anular tarjeta", 1, listaValidacion, subOpciones);
        public static List<OpcionLlamada> opcionesLLamada = new List<OpcionLlamada>() { opcionLlamada };


        //Creamos la llamada
        public static Llamada llamadaIniciada = new Llamada("Descripcion de opcion", "Detalle de Accion", 0, true, "nada", cliente1, accion1, opcionLlamada, subOpcion1, cambiosEstados);

        //Creacion categoria
        public static CategoriaLlamada categoriaLlamada = new CategoriaLlamada("audio mensaje opciones", "mensaje opciones", "Informar Robo", 1, opcionesLLamada);

        
    }
}
