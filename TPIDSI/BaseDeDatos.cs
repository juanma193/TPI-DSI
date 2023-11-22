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
        public static Iniciada estado1 = new Iniciada();
        public static EnCurso estado2 = new EnCurso();
        public static Finalizada estado3 = new Finalizada();

        public static Estado[] estados = { estado1, estado2, estado3 };

        //Creamos accion
        public static Accion accion1 = new Accion("Dar de baja a la tarjeta");
        public static Accion accion2 = new Accion("Pedir nueva tarjeta");
        public static Accion accion3 = new Accion("Pausar acciones de la tarjeta");
        public static Accion accion4 = new Accion("Pausar acciones y pedir nueva tarjeta");
        public static List<Accion> listaAcciones = new List<Accion>() { accion1, accion2, accion3, accion4};


        //Creamos cambios de estados
        public static CambioEstado cambio1 = new CambioEstado(new DateTime(2016, 03, 07), estado1);
        public static List<CambioEstado> cambiosEstados = new List<CambioEstado> { cambio1 };

        //Creacion OpcionesValidacion
        public static OpcionValidacion opcionValidacion1 = new OpcionValidacion("27 de junio", true);
        public static OpcionValidacion opcionValidacion2 = new OpcionValidacion("8 de enero", false);
        public static OpcionValidacion opcionValidacion3 = new OpcionValidacion("22 de mayo", false);
        public static List<OpcionValidacion> validacionList1 = new List<OpcionValidacion>() { opcionValidacion1, opcionValidacion2, opcionValidacion3 };

        //Creacion OpcionesValidacion
        public static OpcionValidacion opcionValidacion4 = new OpcionValidacion("0", false);
        public static OpcionValidacion opcionValidacion5 = new OpcionValidacion("1", false);
        public static OpcionValidacion opcionValidacion6 = new OpcionValidacion("2 o mas", true);
        public static List<OpcionValidacion> validacionList2 = new List<OpcionValidacion>() { opcionValidacion4, opcionValidacion5, opcionValidacion6 };

        //Creacion OpcionesValidacion
        public static OpcionValidacion opcionValidacion7 = new OpcionValidacion("5003", false);
        public static OpcionValidacion opcionValidacion8 = new OpcionValidacion("5021", true);
        public static OpcionValidacion opcionValidacion9 = new OpcionValidacion("6000", false);
        public static List<OpcionValidacion> validacionList3 = new List<OpcionValidacion>() { opcionValidacion7, opcionValidacion8, opcionValidacion9 };

        //Creamos validaciones
        public static Validacion validacion1 = new Validacion("Fecha nacimiento","Validacion de fecha nacimiento", 1, validacionList1);
        public static Validacion validacion2 = new Validacion("Numero hijos","Validacion de numero de hijos", 2, validacionList2);
        public static Validacion validacion3 = new Validacion("Codigo postal","Validacion de codigo postal", 3, validacionList3);
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
