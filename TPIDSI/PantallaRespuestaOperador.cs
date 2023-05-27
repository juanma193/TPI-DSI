using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TPIDSI.BaseDeDatos;

namespace TPIDSI
{
    public partial class PantallaRespuestaOperador : Form
    {
        public PantallaRespuestaOperador()
        {
            InitializeComponent();
        }

        private void PantallaRespuestaOperador_Load(object sender, EventArgs e)
        {
            this.Hide();
            GestorRespuestaOperador.seleccionComunicarseConOperador(llamadaIniciada, categoriaLlamada, opcionLlamada, subOpcion1, this);
        }

        internal void habilitarPantalla()
        {
            this.Show();
        }

        internal void mostrarDatosLlamada(string nombreCategoria, string nombreCliente, string nombreOpcion, string nombreSubOpcion)
        {
            lblNombreCategoria.Text = nombreCategoria;
            lblNombreCliente.Text = nombreCliente;
            lblNombreSubOpcion.Text = nombreSubOpcion;
            lblNombreOpcion.Text = nombreOpcion;
        }

        internal void mostrarMensajeValidacion(string mensajeVal)
        {
            lblMensajeValidacion.Text = mensajeVal;
        }

        internal async void mostrarOpciones(List<string> descripcionOpciones)
        {
            cmbOpciones.Items.Clear();
            foreach (string descripcion in descripcionOpciones)
            {
                cmbOpciones.Items.Add(descripcion);
            }

            //await tomarRespuesta(sender, e);
            
        }

        private void tomarRespuesta(object sender, EventArgs e)
        {
            GestorRespuestaOperador.tomarRespuesta(cmbOpciones.SelectedText);
        }
    }
}
