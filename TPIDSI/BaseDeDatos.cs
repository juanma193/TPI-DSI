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
        public static Accion accion1 = new Accion("Se movio 2 pasos");

        //Creamos cambios de estados
        public static CambioEstado cambio1 = new CambioEstado(new DateTime(2016, 03, 07), estado1);
        public static List<CambioEstado> cambiosEstados = new List<CambioEstado> { cambio1 };

        //Creamos informacion del cliente
        public static InformacionCliente info1 = new InformacionCliente("Hola");
        public static InformacionCliente info2 = new InformacionCliente("Chau");

        //Creamos  la lista de informacion del cliente
        public static List<InformacionCliente> listaInformacion = new List<InformacionCliente>() { info1, info2 };



        //Creacion del cliente
        public static Cliente cliente1 = new Cliente(45690486, "Hassan", 3512012116, listaInformacion);

        //Creacion SubOpciones
        public static SubOpcionLlamada subOpcion1 = new SubOpcionLlamada("SubOpcion1", 1);
        public static SubOpcionLlamada subOpcion2 = new SubOpcionLlamada("SubOpcion 2", 2);
        public static List<SubOpcionLlamada> subOpciones = new List<SubOpcionLlamada>() { subOpcion1, subOpcion2 };

        //Creacion opcionLlamada
        public static OpcionLlamada opcionLlamada = new OpcionLlamada("Hola", "como estas", "Camila", 1, subOpciones);

        
        //Creamos la llamada
        public static Llamada llamadaIniciada = new Llamada("Descripcion de opcion", "Detalle de Accion", 20, true, "nada", cliente1, accion1, opcionLlamada, subOpcion1);


    }
}
